using System.ComponentModel;
using System.Data;
using UserManagementSystem.Data;
using UserManagementSystem.Models.ViewModels;

namespace UserManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        private static DashboardForm? _instance;
        private List<UserViewModel> _originalList = new();

        public static DashboardForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new DashboardForm();
            return _instance;
        }

        public DashboardForm()
        {
            InitializeComponent();

            dgvReports.AutoGenerateColumns = true;
            dgvReports.DataSource = bdsReports;

            LoadData();

            txtSearch.TextChanged += (s, e) => FilterData();
        }

        private void ReportScreen_Load(object sender, EventArgs e) => LoadData();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            try
            {
                var data = CredentialRepository.FindAll();

                // maps database to viewmodel

                _originalList = data.Select(c => new UserViewModel
                {
                    Id = c.User?.Id,
                    Name = c.User?.Name ?? "N/A",
                    Nickname = c.User?.Nickname ?? "N/A",
                    Email = c.Email ?? "",
                    Phone = c.User?.PhoneNumber?.ToString() ?? "N/A",
                    Role = c.Manager ? "Manager" : "Staff",
                    LastAccess = c.LastAccess?.ToString("g") ?? "Never"
                }).ToList();

                FilterData(); // updates the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void FilterData()
        {
            string term = txtSearch.Text.ToLower().Trim();

            var filtered = _originalList.Where(u =>
                u.Name.ToLower().Contains(term) ||
                u.Email.ToLower().Contains(term) ||
                u.Role.ToLower().Contains(term)
            ).ToList();

            // push to bds
            bdsReports.DataSource = new BindingList<UserViewModel>(filtered);
            lblReports.Text = $"User Reports ({filtered.Count})";
        }
    }
}