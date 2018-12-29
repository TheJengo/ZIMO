using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.General_Controls
{
    public partial class ReportsControl : UserControl
    {
        private IChargedController userController;
        private bool isReporterAdmin;

        public ReportsControl()
        {
            InitializeComponent();
        }

        public void SetAuthorization(IChargedController userController, bool isReporterAdmin)
        {
            this.userController = userController;
            this.isReporterAdmin = isReporterAdmin;
            InitializeDetails();
        }

        private IList<User> Users;
        private IList<Department> Departments;
        private IList<FileInfo> Files;
        private User selectedReportEmployee;
        private Department selectedReportDepartment;
        private int selectedReportDepartmentIndex = -1;
        private int selectedReportEmployeeIndex = -1;
        private bool withPassives;

        private void InitializeDetails()
        {
            tbcReport.SelectedTab = tbpReportByEmployee;
            Files = FileUtil.GetFileList()
                .OrderByDescending(x => x.CreationTime).ToList();

            if (isReporterAdmin)
            {
                Users = userController.GetAllUsers(true);
                Departments = userController.GetDepartments();
            }
            else
            {
                Users = userController.GetAllUsers(true)
                    .Where(x => x.Department_Id.Equals(userController.GetUser().Department_Id)).ToList();
                Departments = userController.GetDepartments()
                    .Where(x => x.Id.Equals(userController.GetUser().Department_Id)).ToList();
                cboxIsActive.Enabled = false;
                cboxIsActive.Checked = false;
                lblSearchEmployeeContainPassives.Enabled = false;
            }

            ListUtil.InitializeListView(mlvEmployeeReport, Users.OrderByDescending(x=>x.Borrows.Count).ToList());

            ListUtil.InitializeListView(mlvDepartments, Departments.OrderByDescending(x => x.Users.Count).ToList());

            ListUtil.InitializeListView(mlvReports,Files);
        }

        private void mlvEmployeeReport_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedReportEmployeeIndex = mlvEmployeeReport.FocusedItem.Index;
                selectedReportEmployee = Users.ElementAt(selectedReportEmployeeIndex);

                userController.CreateReport(selectedReportEmployee);

                Files = FileUtil.GetFileList()
                    .OrderByDescending(x => x.CreationTime).ToList();
                ShowReport(Files.ElementAt(0));

                AnimationUtil.ShowSync(pnlReportByPersonAlert);
                AnimationUtil.ShowSync(pnlReportPersonSuccessfulAlert);
            }
        }

        private void mlvDepartments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedReportDepartmentIndex = mlvDepartments.FocusedItem.Index;
                selectedReportDepartment = Departments.ElementAt(selectedReportDepartmentIndex);
                
                userController.CreateReport(userController.GetAllUsers(withPassives).Where(x=>x.Department_Id.Equals(selectedReportDepartment.Id)).ToList());

                Files = FileUtil.GetFileList()
                    .OrderByDescending(x => x.CreationTime).ToList();
                ShowReport(Files.ElementAt(0));

                AnimationUtil.ShowSync(pnlReportDepartmentAlert);
                AnimationUtil.ShowSync(pnlReportDepartmentSuccessfulAlert);
            }
        }

        private void btnCloseReportPersonAlert_Click(object sender, EventArgs e)
        {
            AnimationUtil.HideSync(pnlReportByPersonAlert);
            AnimationUtil.HideSync(pnlReportPersonSuccessfulAlert);
            AnimationUtil.HideSync(pnlReportPersonFailAlert);

            tbcReport.SelectedTab = tbpReportDetail;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AnimationUtil.HideSync(pnlReportDepartmentAlert);
            AnimationUtil.HideSync(pnlReportDepartmentSuccessfulAlert);
            AnimationUtil.HideSync(pnlReportDepartmentFailAlert);

            tbcReport.SelectedTab = tbpReportDetail;
        }

        // If checkbox selected updates withPassives variable
        private void cboxIsActive_OnChange(object sender, EventArgs e)
        {
            if (cboxIsActive.Checked)
                withPassives = true;
            else
                withPassives = false;

            dropEmployeeSearchKey_onItemSelected(this, e);
        }

        // Toggle Employee Is Active checkbox
        private void lblSearchEmployeeContainPassives_Click(object sender, EventArgs e)
        {
            if (cboxIsActive.Checked)
                cboxIsActive.Checked = false;
            else
                cboxIsActive.Checked = true;

            cboxIsActive_OnChange(this, e);
        }

        // Search By parameters after selected from dropdown list
        private void dropEmployeeSearchKey_onItemSelected(object sender, EventArgs e)
        {
            Users = userController.GetAllUsers(withPassives).Where(x =>
                x.Department.Id.Equals(userController.GetUser().Department_Id)).ToList();

            switch (dropEmployeeSearchKey.selectedIndex)
            {
                case 0:
                    Users = Users.Where(x => x.Username.ToLower().Contains(txtSearchEmployee.Text.ToLower())).ToList();
                    break;
                case 1:
                    Users = Users.Where(x => x.Employee.FirstName.ToLower().Contains(txtSearchEmployee.Text.ToLower()))
                        .ToList();
                    break;
                case 2:
                    Users = Users.Where(x => x.Employee.LastName.ToLower().Contains(txtSearchEmployee.Text.ToLower()))
                        .ToList();
                    break;
                case 3:
                    Users = Users.Where(x => x.Department.Name.ToLower().Contains(txtSearchEmployee.Text.ToLower()))
                        .ToList();
                    break;
                case 4:
                    Users = Users.Where(x => x.Role.Name.ToLower().Contains(txtSearchEmployee.Text.ToLower())).ToList();
                    break;
                default:
                    Users = Users.Where(x => x.Username.ToLower().Contains(txtSearchEmployee.Text.ToLower())).ToList();
                    break;
            }

            ListUtil.InitializeListView(mlvEmployeeReport, Users);
        }

        // Checks search employee textbox values
        private void txtSearchEmployee_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = txtSearchEmployee.MaximumLength(200);
            dropEmployeeSearchKey_onItemSelected(this, e);
        }

        // Search Departments by name
        private void txtManageDepartmentsSearch_OnValueChanged(object sender, EventArgs e)
        {
            txtManageDepartmentsSearch.Text = txtManageDepartmentsSearch.MaximumLength(200);
            if (isReporterAdmin)
                Departments = userController.GetDepartments().Where(x => x.Name.ToLower().Contains(txtManageDepartmentsSearch.Text.ToLower())).ToList();
            else
                Departments = userController.GetDepartments().Where(x => x.Id.Equals(userController.GetUser().Department_Id) && x.Name.ToLower().Contains(txtManageDepartmentsSearch.Text.ToLower())).ToList();
            ListUtil.InitializeListView(mlvDepartments, Departments);
        }

        private FileInfo selectedFile;
        private int selectedFileIndex;
        private void mlvReports_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedFileIndex = mlvReports.FocusedItem.Index;
                selectedFile = Files.ElementAt(selectedFileIndex);
                
                ShowReport(selectedFile);
            }
        }

        private void btnClosePdfViewer_Click(object sender, EventArgs e)
        {
            pnlReportViewer.Visible = false;
            pdfReportViewer.Navigate("");
        }

        private void ShowReport(FileInfo file)
        {
            pdfReportViewer.Navigate(file.FullName);

            pnlReportViewer.Visible = true;
            pnlReportViewer.BringToFront();
            
        }
    }
}