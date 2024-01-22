/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using FluentValidation.Results;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace cms.Common
{
    public static class Helper
    {
        public const string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static CultureInfo GetCulture()
        {
            var cultureInfo = new CultureInfo("en-MY");
            cultureInfo.NumberFormat.CurrencyPositivePattern = 2;
            return cultureInfo;
        }
        public static string AsCurrency(double value)
        {
            return value.ToString("C2", GetCulture());
        }        
        public static bool IsLetterOrDigit(string value)
        {
            return value.All(char.IsLetterOrDigit);
        }        
        public static bool IsValidName(string value)
        {
            value = value.Replace(" ", "");
            value = value.Replace("-", "");
            return value.All(char.IsLetter);
        }
        public static void ShowGenericErrorDialog()
        {
            MessageBox.Show(
                "Please try again or contact your IT administrator.", 
                "Something Went Wrong!", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
        public static bool ShowDeleteConfirmationDialog()
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Are You Sure?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            return result == DialogResult.OK;
        }
        public static void ShowValidationErrorDialog(ValidationResult validationResults)
        {
            string errors = string.Empty;
            foreach (ValidationFailure result in validationResults.Errors)
            {
                errors += result.ErrorMessage + Environment.NewLine;
            }
            MessageBox.Show(
                errors, 
                "Validation Error(s)!", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
    }
}
