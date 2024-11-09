using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal class ValidateData
    {
        private static List<Credentials> credentials = FileOperations.ReadFromAFile();
        public static Boolean IsValidCredentials(String username, string enteredPassword)
        {
            foreach(var credential in credentials)
            {
                if((credential.EmailID.Equals(username, StringComparison.OrdinalIgnoreCase) && 
                    credential.Password.Equals(enteredPassword, StringComparison.OrdinalIgnoreCase)))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean EmailRegex(string username)
        {
            
            string emailPattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(username);
        }

        public static bool PassMatch(string password1, string password2)
        {
            // Check if fields are null or not
            if (password1 == null || password2 == null)
            {
                return false;
            }

            // Check if lengths are different
            if (password1.Length != password2.Length)
            {
                return false;
            }

            return password1.Equals(password2);
        }

        public static bool EmailAvailability(string email)
        {
            foreach(var credential in credentials) 
            {
                if (credential.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EmptyFieldChecks(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }
    }
}
