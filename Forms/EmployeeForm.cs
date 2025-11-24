using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.ComponentModel;

namespace UserManagementSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private static EmployeeForm? _instance;
        private Models.User? _loggedInUser;
        private readonly Repository _dbContext;
        private BindingList<User> _employees;


        public static EmployeeForm GetInstance(Models.User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new EmployeeForm();
            }

            _instance._loggedInUser = user;
            return _instance;
        }

        public EmployeeForm()
        {
            InitializeComponent();

            _dbContext = new Repository();
            _dbContext.Users.Load();

            _employees = _dbContext.Users.Local.ToBindingList();

            DataGridViewEmployee.DataSource = _employees;

            ColumnEmployeeId.DataPropertyName = nameof(Models.User.Id);
            ColumnEmployeeName.DataPropertyName = nameof(Models.User.Name);
            ColumnEmployeeNickname.DataPropertyName = nameof(Models.User.Nickname);
            ColumnEmployeeEmail.DataPropertyName = nameof(Models.User.Email);
            ColumnEmployeePhone.DataPropertyName = nameof(Models.User.PhoneNumber);
        }
    }
}
