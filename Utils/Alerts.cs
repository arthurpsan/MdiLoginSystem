using System.Windows.Forms;

namespace UserManagementSystem.Utils
{
    public static class Alerts
    {
        public static void ShowSuccess(string message)
            => MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void ShowError(string message)
            => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowWarning(string message)
            => MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool ConfirmAction(string message)
        {
            return MessageBox.Show(message, "Confirm Action",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}