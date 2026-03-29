using System;
using System.Text.RegularExpressions;

namespace DVLD
{
    internal static class InputValidation
    {
        // Universal regex patterns for validation
        private const string NumberPattern = @"^\d+$";
        private const string DecimalPattern = @"^\d+(\.\d+)?$";
        private const string EmailPattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,}$";
        private const string PhonePattern = @"^\+?\d{7,15}$";
        private const string AlphaPattern = @"^[a-zA-Z]+$";
        private const string AlphaWithSpacesPattern = @"^[a-zA-Z ]+$";
        private const string DatePattern = @"^\d{4}-\d{2}-\d{2}$";
        private const string AlphanumericPattern = @"^[a-zA-Z0-9]+$";
        private const string UsernamePattern = @"^\w+$";
        private const string PasswordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

        private static readonly TimeSpan RegexTimeout = TimeSpan.FromMilliseconds(250);

        public static bool IsNotEmpty(string input, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "Input cannot be empty.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsNumber(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, NumberPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be a valid number.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsDecimal(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, DecimalPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be a valid decimal number.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsEmail(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, EmailPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be a valid email address.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsPhoneNumber(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, PhonePattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be a valid phone number.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsAlpha(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, AlphaPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must contain only letters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsAlphaWithSpaces(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, AlphaWithSpacesPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must contain only letters and spaces.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsDate(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, DatePattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be a valid date in YYYY-MM-DD format.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsAlphanumeric(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, AlphanumericPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Input must be alphanumeric (letters and numbers only).";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsUsername(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, UsernamePattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Username can only contain letters, numbers, and underscores.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsPassword(string input, out string errorMessage)
        {
            if (!Regex.IsMatch(input ?? string.Empty, PasswordPattern, RegexOptions.None, RegexTimeout))
            {
                errorMessage = "Password must be at least 8 characters, include at least one letter and one number.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsWithinLength(string input, int minLength, int maxLength, out string errorMessage)
        {
            if (input == null || input.Length < minLength || input.Length > maxLength)
            {
                errorMessage = $"Input must be between {minLength} and {maxLength} characters long.";
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
