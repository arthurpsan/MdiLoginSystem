using System;
using System.Windows.Forms;

namespace UserManagementSystem.Utils
{
    public static class Alerts
    {
        public static void ShowSuccess(String message)
            => MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void ShowError(String message)
            => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowWarning(String message)
            => MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool ConfirmAction(String message)
        {
            return MessageBox.Show(message, "Confirm Action",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}