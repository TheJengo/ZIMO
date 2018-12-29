using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZIMO.App.Utils
{
    public static class TextUtil
    {
        /// <summary>
        /// Validating input value is a valid email address.
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>True/False</returns>
        public static bool IsEmail(string inputValue)
        {
            /*
             * This mail pattern taken from EF6 open source code
             * You can reach it at:
             * https://referencesource.microsoft.com/#System.ComponentModel.DataAnnotations/DataAnnotations/EmailAddressAttribute.cs
             * line 54 - 55
             */
            const string pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
            return Regex.IsMatch(inputValue,pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// When password field length is 0 textfield has a visual/behavioral bug
        /// This method tries to cover that problem.
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>String</returns>
        public static string PasswordFieldManager(string inputValue)
        {
            if (inputValue.Length == 0)
            {
                return "password";
            }

            return inputValue;
        }

        /// <summary>
        /// Gives info about is text null or not?
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>True/False</returns>
        public static bool IsNull(string inputValue)
        {
            return (inputValue == null || inputValue.Trim().Length == 0 );
        }

        /// <summary>
        /// Checks the string is full integer?
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>True/False</returns>
        public static bool IsDigit(string inputValue)
        {
            return (!IsNull(inputValue) && inputValue.Length < 10 ) ? inputValue.All(char.IsDigit):false;
        }

        /// <summary>
        /// Check the string is money?
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>True/False</returns>
        public static bool IsMoney(string inputValue)
        {
            return (!IsNull(inputValue) && inputValue.Length < 10 ) ? Int32.TryParse(inputValue, (NumberStyles.Integer | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), CultureInfo.CurrentCulture ,out int value) : false;
        }

        /// <summary>
        /// Check the string is money?
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>Decimal output</returns>
        public static decimal ParseMoney(string inputValue)
        {
            decimal value =0;
            bool success = (!IsNull(inputValue) && inputValue.Length < 10 ) ? Decimal.TryParse(inputValue, (NumberStyles.Integer | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), CultureInfo.CurrentCulture, out value) : false;
            return success ? value : 0 ;
        }

        /// <summary>
        /// Checks the string is all letters?
        /// </summary>
        /// <param name="inputValue">String value</param>
        /// <returns>True/False</returns>
        public static bool IsOnlyLetters(string inputValue)
        {
            return inputValue.All(Char.IsLetter);
        }
    }
}
