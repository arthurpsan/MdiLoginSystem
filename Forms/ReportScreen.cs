using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    public partial class ReportScreen : Form
    {
        private static ReportScreen? _instance;
        public static ReportScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ReportScreen();
            }
            return _instance;
        }

        public ReportScreen()
        {
            InitializeComponent();
        }

        private void ReportScreen_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadReportData();
        }

        private void SetupListView()
        {
            lstReports.View = View.Details;
            lstReports.GridLines = true;
            lstReports.FullRowSelect = true;

            lstReports.ColumnWidthChanging += lstReports_ColumnWidthChanging;
        }

        private void lstReports_ColumnWidthChanging(object? sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;

            e.NewWidth = lstReports.Columns[e.ColumnIndex].Width;
        }

        // Method to load user report
        private void LoadReportData()
        {
            // Implementation for loading user report
            try
            {
                lstReports.Items.Clear();

                List<Credential> credentials = CredentialRepository.FindAll();

                foreach (Credential credential in credentials)
                {
                    // Creates a "ghost line" in order to avoid clashing alignment with the first column rule

                    ListViewItem line = new ListViewItem(string.Empty);

                    line.SubItems.Add(credential.User?.Id.ToString() ?? "N/A");
                    line.SubItems.Add(credential.User.Name);
                    line.SubItems.Add(credential.User.Nickname);
                    line.SubItems.Add(credential.Email);
                    line.SubItems.Add(credential.User.PhoneNumber?.ToString() ?? "N/A");

                    string level = credential.Manager ? "Admin" : "Regular";
                    line.SubItems.Add(level);

                    line.SubItems.Add(credential.LastAccess?.ToString() ?? "Never");

                    lstReports.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }
    }
}
