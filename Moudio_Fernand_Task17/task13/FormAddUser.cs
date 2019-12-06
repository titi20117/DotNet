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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string rewardsOfUser = " ";
                var checkedRewards = this.rewards.CheckedItems;
                foreach (var c in checkedRewards)
                {
                    rewardsOfUser = rewardsOfUser + " " + c.ToString();
                }
                Program.usersBL.Add(tbFirstName.Text, tbLastName.Text, DateTime.Parse(tbBerthdate.Text), rewardsOfUser);
                MainForm main = this.Owner as MainForm;
                main.dgwUsers.DataSource = Program.usersBL.GetList().ToList();
                if (Program.usersBL.GetList().Count() != 0)
                {
                    main.btnEditUsers.Enabled = true;
                }
                else
                {
                    main.btnEditUsers.Enabled = false;
                }
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbBerthdate.Text = "";
                for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
                {
                    rewards.Items[i] = Program.rewardsBL.GetList().ToList()[i].Title;
                    rewards.SetItemChecked(i, false);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                MainForm main = new MainForm();
                main.dgwRewards.DataSource = Program.usersBL.GetList().ToList();
                this.Close();
        }

        private void btnAhead_Click(object sender, EventArgs e)
        {
            Program.usersBL.indexOfUser++;
            if (Program.usersBL.indexOfUser >= Program.usersBL.GetList().Count())
            {
                Program.usersBL.indexOfUser = 0;
            }
            tbFirstName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].FirstName;
            tbLastName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].LastName;
            tbBerthdate.Text = Convert.ToString(Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Birthdate);
            
            for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
            {
                rewards.Items[i] = Program.rewardsBL.GetList().ToList()[i].Title;
            }
            for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
            {
                if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards!=null)
                {
                    if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards.Contains(Program.rewardsBL.GetList().ToList()[i].Title))
                        rewards.SetItemChecked(i, true);
                    
                }
                else
                    rewards.SetItemChecked(i, false);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.usersBL.indexOfUser--;
            if (Program.usersBL.indexOfUser < 0  )
            {
                Program.usersBL.indexOfUser = Program.usersBL.GetList().Count()- 1;
            }
            tbFirstName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].FirstName;
            tbLastName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].LastName;
            tbBerthdate.Text = Convert.ToString(Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Birthdate);
            
            for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
            {
                rewards.Items[i] = Program.rewardsBL.GetList().ToList()[i].Title;
            }
            for (int i = 0; i < Program.rewardsBL.GetList().Count(); i++)
            {
                if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards!=null)
                {
                    if (Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Rewards.Contains(Program.rewardsBL.GetList().ToList()[i].Title))
                        rewards.SetItemChecked(i, true);
                   
                }
                else
                    rewards.SetItemChecked(i, false);

            }
        }

        

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string rewardsOfUser = " ";
                var checkedRewards = this.rewards.CheckedItems;
                foreach (var c in checkedRewards)
                {
                    rewardsOfUser = rewardsOfUser + " " + c.ToString();
                }
                Program.usersBL.Edit(tbFirstName.Text, tbLastName.Text, DateTime.Parse(tbBerthdate.Text), rewardsOfUser);
                MainForm main = this.Owner as MainForm;
                main.dgwUsers.DataSource = Program.usersBL.GetList().ToList();
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {  
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить этого пользователя из списка?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Program.usersBL.GetList().Count() != 1)
                {
                    Program.usersBL.Delete();
                    MainForm main = this.Owner as MainForm;
                    main.dgwUsers.DataSource = Program.usersBL.GetList().ToList();
                    tbFirstName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].FirstName;
                    tbLastName.Text = Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].LastName;
                    tbBerthdate.Text = Convert.ToString(Program.usersBL.GetList().ToList()[Program.usersBL.indexOfUser].Birthdate);
                }
                else
                {
                    Program.usersBL.Delete();
                    MainForm main = this.Owner as MainForm;
                    this.btnDelete.Enabled = false;
                    main.btnEditUsers.Enabled = false;
                    this.Close();
                }
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (tbFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(tbFirstName, "Строка не должна быть пустой");
                e.Cancel = true;
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider2.Clear();
            if (tbLastName.Text == string.Empty)
            {
                errorProvider2.SetError(tbLastName, "Строка не должна быть пустой");
                e.Cancel = true;
            }
        }

        private void tbBerthdate_Validating(object sender, CancelEventArgs e)
        {
            errorProvider3.Clear();
            if (tbBerthdate.Text == string.Empty)
            {
                errorProvider3.SetError(tbBerthdate, "Строка не должна быть пустой");
                e.Cancel = true;
            }
        }
    }
}
