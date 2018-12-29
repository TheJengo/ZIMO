using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.Admin_Controls
{
    public partial class DepartmentControl : UserControl
    {
        private IAdminController userController;
        public DepartmentControl()
        {
            InitializeComponent();
        }

        public void SetAuthorization(IAdminController userController)
        {
            this.userController = userController;
            InitializeDetails();
        }

        /// <summary>
        /// Manage Department Menu button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private IList<Department> Departments;
        private Department selectedDepartment;
        private int selectedDepartmentIndex = -1;
        private void InitializeDetails()
        {
            txtManageDepartmentsAdd.Text = "";
            txtManageDepartmentUpdate.Text = "";
            txtManageDepartmentsSearch.Text = "";

            selectedDepartmentIndex = -1;
            Departments = userController.GetDepartments();
            ListUtil.InitializeListView(mlvDepartments, Departments);

        }

        // Search Departments by name
        private void txtManageDepartmentsSearch_OnValueChanged(object sender, EventArgs e)
        {
            txtManageDepartmentsSearch.Text = txtManageDepartmentsSearch.MaximumLength(200);
            Departments = userController.GetDepartments().Where(x => x.Name.ToLower().Contains(txtManageDepartmentsSearch.Text.ToLower())).ToList();
            ListUtil.InitializeListView(mlvDepartments, Departments);
        }

        private void mlvDepartments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedDepartmentIndex = mlvDepartments.FocusedItem.Index;
                selectedDepartment = Departments.ElementAt(selectedDepartmentIndex);

                txtManageDepartmentUpdate.Text = selectedDepartment.Name;
            }
        }
        // Update Selected Department
        private void btnManageDepartmentsUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDepartment != null &&
                !TextUtil.IsNull(txtManageDepartmentUpdate.Text) &&
                !selectedDepartment.Name.ToLower().Equals(txtManageDepartmentUpdate.Text))
            {
                selectedDepartment.Name = txtManageDepartmentUpdate.Text;
                userController.ManageDepartment(selectedDepartment, EntityState.Modified);

                lblManageDepartmentUpdateFailAlert.Visible = false;
                lblManageDepartmentUpdateSuccessAlert.Visible = true;
            }
            else
            {
                lblManageDepartmentUpdateSuccessAlert.Visible = false;
                lblManageDepartmentUpdateFailAlert.Visible = true;
            }

            txtManageDepartmentsSearch_OnValueChanged(this, e);
        }

        // Add department
        private void btnManageDepartmentsAdd_Click(object sender, EventArgs e)
        {
            if (!TextUtil.IsNull(txtManageDepartmentsAdd.Text) &&
               Departments.FirstOrDefault(x => x.Name.ToLower().Equals(txtManageDepartmentsAdd.Text.ToLower())) == null)
            {
                Department department = new Department()
                {
                    Name = txtManageDepartmentsAdd.Text
                };
                userController.ManageDepartment(department, EntityState.Added);

                lblManageDepartmentsAddFailAlert.Visible = false;
                lblManageDepartmentsAddSuccessfulAlert.Visible = true;
            }
            else
            {
                lblManageDepartmentsAddSuccessfulAlert.Visible = false;
                lblManageDepartmentsAddFailAlert.Visible = true;
            }

            txtManageDepartmentsSearch_OnValueChanged(this, e);
        }

        private void btnManageDepartmentsDelete_Click(object sender, EventArgs e)
        {
            if (selectedDepartment != null && selectedDepartment.Users.Count == 0)
            {
                userController.ManageDepartment(selectedDepartment,EntityState.Deleted);

                lblManageDepartmentUpdateFailAlert.Visible = false;
                lblManageDepartmentUpdateSuccessAlert.Visible = true;
            }
            else
            {
                lblManageDepartmentUpdateSuccessAlert.Visible = false;
                lblManageDepartmentUpdateFailAlert.Visible = true;
            }
            InitializeDetails();
        }
        private void txtManageDepartmentUpdate_OnValueChanged(object sender, EventArgs e)
        {
            txtManageDepartmentUpdate.Text = txtManageDepartmentUpdate.MaximumLength(50);
        }

        private void txtManageDepartmentsAdd_OnValueChanged(object sender, EventArgs e)
        {
            txtManageDepartmentsAdd.Text = txtManageDepartmentsAdd.MaximumLength(50);
        }

    }
}
