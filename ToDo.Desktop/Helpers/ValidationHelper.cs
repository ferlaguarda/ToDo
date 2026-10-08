namespace ToDo.Desktop.Helpers
{
    internal static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    
        public static bool HasContent(string input, string fieldName)
        {
            if (!string.IsNullOrEmpty(input))
                return true;

            MessageBox.Show($"El {fieldName} es obligatorio", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;
        }

        public static bool HasContent(TextBox input, string fieldName)
        {
            if (!string.IsNullOrEmpty(input.Text))
                return true;

            MessageBox.Show($"El {fieldName} es obligatorio", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;

        }
    }
}
