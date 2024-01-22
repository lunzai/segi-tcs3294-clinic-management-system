/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using CsvHelper.Configuration.Attributes;
using System.Data.SQLite;

namespace cms.Models
{
    public class BaseModel
    {
        [Index(0)]
        [Name("ID")]
        public virtual int? Id { get; set; }
        [Ignore]
        public bool IsNewRecord { get => Id == null; }
        private SQLiteConnection _conn { get; set; }
        private string _connectionString = "Data Source=Data/CmsDb.db;Version=3;";
        public SQLiteConnection GetDb()
        {
            if (_conn == null)
            {
                _conn = new SQLiteConnection(_connectionString);
                _conn.Open();
            }
            return _conn;
        }
    }
}
