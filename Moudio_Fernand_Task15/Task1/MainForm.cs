using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UserAwards.BLL;
using UserAwards.DAL;
using Entities;

namespace Task1
{
    public partial class MainForm : Form
    {
        private readonly UsersBL userService;
        private readonly AwardsBL awardService;
        private readonly AwardingUsersBL awardingService;

        public MainForm()
        {
            userService = new UsersBL(new UserModel());
            awardService = new AwardsBL();
            awardingService = new AwardingUsersBL();
            InitializeComponent();
            ctlUsers.AutoGenerateColumns = false;
        }

        private void ctlFileInsertUser_Click(object sender, EventArgs e)
        {
            UserForm newUserForm = new UserForm();
            if (newUserForm.ShowDialog(this) == DialogResult.OK)
            {
                userService.CreateNewUser
                    (
                    newUserForm.FirstName,
                    newUserForm.LastName,
                    newUserForm.BirthDay
                    );

            }
            UpdateUserDataGridView();
        }

        private void ctlFileInsertAward_Click(object sender, EventArgs e)
        {
            AwardForm NewAwardForm = new AwardForm();
            if (NewAwardForm.ShowDialog(this) == DialogResult.OK)
            {
                awardService.CreateNewAward
                    (
                    NewAwardForm.Title,
                    NewAwardForm.Description
                    );
            }
            UpdateAwardDataGridView();
        }


        private void ctlFileEditUser_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void ctlFileEditAward_Click(object sender, EventArgs e)
        {
            EditSelectedAward();
        }

        private void EditSelectedAward()
        {
            
        }

        private void EditSelectedUser()
        {
            
        }
        private void ctlFileRemoveUser_Click(object sender, EventArgs e)
        {
            RemoveSelectedUser();
        }

        private void ctlFileRemoveAward_Click(object sender, EventArgs e)
        {
            RemoveSelectedAward();
        }

        private void RemoveSelectedAward()
        {
            
        }

        private void RemoveSelectedUser()
        {
            
        }

        private void ctlFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserDataGridView()
        {
            ctlUsers.DataSource = null;
            ctlUsers.DataSource = userService.GetList();
        }
        private void UpdateAwardDataGridView()
        {
            ctlAwards.DataSource = null;
            ctlAwards.DataSource = awardService.GetList();
        }
    }
}
