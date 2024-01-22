/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using CsvHelper.Configuration.Attributes;
using Dapper;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cms.Models
{
    public class User : BaseModel
    {
        public const string STATUS_ACTIVE = "Active";
        public const string STATUS_INACTIVE = "Inactive";
        public const string STATUS_DELETED = "Deleted";

        public const string TYPE_ADMIN = "Admin";
        public const string TYPE_STAFF = "Staff";

        public const string EMPLOYMENT_PARTTIME = "Part-time";
        public const string EMPLOYMENT_FULLTIME = "Full-time";
        [Ignore]
        public ValidationResult ValidationResults { get; set; }
        private string _tableName = "Users";
        [Index(1)]
        public string Username { get; set; } = string.Empty;
        [Ignore]
        public string PasswordHash { get; set; } = string.Empty;
        [Index(2)]
        public string Type { get; set; } = string.Empty;
        [Index(3)]
        public string Status { get; set; } = STATUS_INACTIVE;
        [Index(4)]
        public string Name { get; set; } = string.Empty;
        [Index(5)]
        [Name("Contact Number")]
        public string ContactNumber { get; set; } = string.Empty;
        [Index(6)]
        public string Email { get; set; } = string.Empty;
        [Index(7)]
        public string Address { get; set; } = string.Empty;
        [Ignore]
        public DateTime? DateOfBirth { get; set; } = null;
        [Name("Employement Type")]
        public string EmploymentType { get; set; } = string.Empty;
        [Name("Created At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Name("Updated At")]
        public DateTime? UpdatedAt { get; set; } = null;
        [Name("Last Logon At")]
        public DateTime? LastLogonAt { get; set; } = null;
        [Ignore]
        public DateTime? DeletedAt { get; set; } = null;
        [Ignore]
        public bool IsActive { get => Status == STATUS_ACTIVE; }
        [Ignore]
        public bool IsAdmin { get => Type == TYPE_ADMIN; }
        [Index(8)]
        [Name("Date Of Birth")]
        public string DisplayDateOfBirth { get => DateOfBirth.HasValue ? DateOfBirth.Value.ToString("yyyy-MM-dd") : "-"; }
        public void SetPassword(string password)
        {
            PasswordHash = Hash.Generate(password);
        }
        public void TouchLastLogonAt()
        {
            if (Id != null)
            {
                GetDb().Execute($"UPDATE {_tableName} SET LastLogonAt = @Now WHERE Id = @Id", new
                {
                    Id, DateTime.Now,
                });
            }            
        }
        public bool UpdatePassword(string password)
        {
            try
            {
                string sql = $@"
                    UPDATE Users 
                    SET PasswordHash = @PasswordHash, UpdatedAt = @Now
                    WHERE Id = @Id                    
                ";
                int affectedRows = GetDb().Execute(sql, new
                {
                    Id, PasswordHash = Hash.Generate(password), DateTime.Now,
                });
                return affectedRows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Save()
        {
            try
            {
                if (IsNewRecord)
                { // insert
                    string sql = $@"
                        INSERT INTO {_tableName} 
                        (
                            Username, PasswordHash, Type, Status, Name, 
                            ContactNumber, Email, Address, DateOfBirth, 
                            EmploymentType, CreatedAt, UpdatedAt
                        )
                        VALUES (
                            @Username, @PasswordHash, @Type, @Status, @Name, 
                            @ContactNumber, @Email, @Address, @DateOfBirth, 
                            @EmploymentType, @Now, @Now
                        )
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Username, PasswordHash, Type, Status, Name,
                        ContactNumber, Email, Address, EmploymentType,
                        DateOfBirth, DateTime.Now
                    });
                    if (affectedRows > 0)
                    {
                        int id = GetDb().ExecuteScalar<int>("SELECT last_insert_rowid()");
                        Id = id;
                        return true;
                    };
                }
                else
                { // update
                    string sql = $@"
                        UPDATE {_tableName} 
                        SET Username = @Username, Type = @Type, Status = @Status, Name = @Name, ContactNumber = @ContactNumber, 
                            Email = @Email, Address = @Address, DateOfBirth = @DateOfBirth, EmploymentType = @EmploymentType, 
                            Status = @Status, UpdatedAt = @Now 
                        WHERE Id = @Id                    
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Id, Username, Type, Status, Name, ContactNumber, Email, Address,
                        DateOfBirth, EmploymentType, DateTime.Now
                    });
                    if (affectedRows > 0)
                    {
                        return true;
                    };
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                return GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, DeletedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_DELETED, DateTime.Now }
                ) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<User> FindAll()
        {
            List<User> models = new List<User>();
            models = GetDb()
                .Query<User>(
                    $"SELECT * FROM {_tableName} WHERE Status != @Status", 
                    new { Status = STATUS_DELETED }
                )
                .ToList();
            return models;
        }
        public List<User> FindAllStaff()
        {
            List<User> models = new List<User>();
            models = GetDb()
                .Query<User>(
                    $"SELECT * FROM {_tableName} WHERE Type = @Type AND Status != @Status", 
                    new { Type = "Staff", Status = STATUS_DELETED }
                )
                .ToList();
            return models;
        }
        public User FindByUsername(string username)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Username = @Username LIMIT 1";
            User model = GetDb()
                .QuerySingle<User>(sql, new
                {
                    Username = username
                });
            return model;
        }
    }
}
