using System;
using Department.BLL;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnEditRewards.Enabled = true;
            btnEditUsers.Enabled = true;
            dgwRewards.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "aID", HeaderText = "ID", DataPropertyName = "ID" },
                new DataGridViewTextBoxColumn() { Name = "aTitle", HeaderText = "Title", DataPropertyName = "Title" },
                new DataGridViewTextBoxColumn() { Name = "aDescription", HeaderText = "Description", DataPropertyName = "Description" }
                );
            dgwUsers.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "aID", HeaderText = "ID", DataPropertyName = "ID" },
                new DataGridViewTextBoxColumn() { Name = "aFirstName", HeaderText = "FirstName", DataPropertyName = "FirstName" },
                new DataGridViewTextBoxColumn() { Name = "aLastName", HeaderText = "LastName", DataPropertyName = "LastName" },
                new DataGridViewTextBoxColumn() { Name = "aBirthdate", HeaderText = "Birthdate", DataPropertyName = "Birthdate" },
                new DataGridViewTextBoxColumn() { Name = "aAge", HeaderText = "Age", DataPropertyName = "Age" },
                new DataGridViewTextBoxColumn() { Name = "aRewards", HeaderText = "Rewards", DataPropertyName = "Rewards" }
                );
            dgwUsers.DataSource = Program.usersBL.GetList().ToList();
            dgwRewards.DataSource = Program.rewardsBL.GetList().ToList();
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        
        private void btnAddRewards_Click(object sender, EventArgs e)
        {
            FormAddRewards addRewards = new FormAddRewards();
            addRewards.Owner = this;
            addRewards.btnSaveAdd.Visible = true;
            addRewards.btnExit.Visible = true;
            addRewards.btnAhead.Visible = false;
            addRewards.btnBack.Visible = false;
            addRewards.btnSaveChanges.Visible = false;
            addRewards.btnDelete.Visible = false;
            addRewards.Show();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = new FormAddUser();
            addUser.Owner = this;
            foreach (Rewards r in Program.rewardsBL.GetList().ToList())
            {
                addUser.rewards.Items.Add(r.Title);
            }
            addUser.btnSaveAdd.Visible = true;
            addUser.btnExit.Visible = true;
            addUser.btnAhead.Visible = false;
            addUser.btnBack.Visible = false;
            addUser.btnSaveEdit.Visible = false;
            addUser.btnDelete.Visible = false;
            addUser.Show();
        }

        private void btnEditRewards_Click(object sender, EventArgs e)
        {
            FormAddRewards formAddRewards = new FormAddRewards();
            formAddRewards.Owner = this;
            formAddRewards.btnSaveAdd.Visible = false;
            formAddRewards.btnExit.Visible = false;
            formAddRewards.btnAhead.Visible = true;
            formAddRewards.btnBack.Visible = true;
            formAddRewards.btnSaveChanges.Visible = true;
            formAddRewards.btnDelete.Visible = true;
            Program.rewardsBL.indexOfReward = 0;
            formAddRewards.tbTitle.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Title;
            formAddRewards.tbDescription.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Description;
            formAddRewards.Show();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = new FormAddUser();
            addUser.Owner = this;
            foreach (Rewards r in Program.rewardsBL.GetList().ToList())
            {
                addUser.rewards.Items.Add(r.Title);
            }
            Program.usersBL.indexOfUser = 0;
            addUser.tbFirstName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].FirstName;
            addUser.tbLastName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].LastName;
            addUser.tbBerthdate.Text = Convert.ToString(Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Birthdate);
            for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
            {
                addUser.rewards.Items[i] = Program.rewardsBL.GetList().ToList()[i].Title;
                if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards!=null)
                {
                    if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards.Contains(Program.rewardsBL.GetList().ToList()[i].Title))
                        addUser.rewards.SetItemChecked(i, true);
                }
                
            }
            addUser.btnSaveAdd.Visible = false;
            addUser.btnExit.Visible = false;
            addUser.btnAhead.Visible = true;
            addUser.btnBack.Visible = true;
            addUser.btnSaveEdit.Visible = true;
            addUser.btnDelete.Visible = true;
            addUser.Show();
        }
    }
}
