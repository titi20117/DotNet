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
    public partial class FormAddRewards : Form
    {
        
        public FormAddRewards()
        {
            InitializeComponent();
            MainForm main = this.Owner as MainForm;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Program.rewardsBL.Add(tbTitle.Text, tbDescription.Text);
                MainForm main = this.Owner as MainForm;
                main.dgwRewards.DataSource = Program.rewardsBL.GetList().ToList();
                if (Program.rewardsBL.GetList().Count() != 0)
                {
                    main.btnEditRewards.Enabled = true;
                }
                else
                {
                    main.btnEditRewards.Enabled = false;
                }
                tbTitle.Text = string.Empty;
                tbDescription.Text = string.Empty;
            }
           
        }

        private void btnAhead_Click(object sender, EventArgs e)
        {
            Program.rewardsBL.indexOfReward++;
            if (Program.rewardsBL.indexOfReward >= Program.rewardsBL.GetList().Count())
            {
                Program.rewardsBL.indexOfReward = 0;
            }
            tbTitle.Text= Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Title;
            tbDescription.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Description; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.rewardsBL.indexOfReward--;
            if (Program.rewardsBL.indexOfReward < 0)
            {
                Program.rewardsBL.indexOfReward = Program.rewardsBL.GetList().Count() - 1;
            }
            tbTitle.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Title;
            tbDescription.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Description;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.dgwRewards.DataSource = Program.rewardsBL.GetList().ToList();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Program.rewardsBL.Edit(Program.rewardsBL.indexOfReward, tbTitle.Text, tbDescription.Text);
                MainForm main = this.Owner as MainForm;
                main.dgwRewards.DataSource = Program.rewardsBL.GetList().ToList();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту награду из списка?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
                if (Program.rewardsBL.GetList().Count() != 1)
                {
                    string rewardForDelete = Program.rewardsBL.Delete();
                    for (int i = 0; i < Program.usersBL.GetList().Count(); i++)
                    {if ((Program.usersBL.GetList().ToList()[i].Rewards != null))
                        {
                            if (Program.usersBL.GetList().ToList()[i].Rewards.Contains(rewardForDelete))
                                Program.usersBL.DeleteReward(i, rewardForDelete);
                        }
                        
                    }
                    MainForm main = this.Owner as MainForm;
                    main.dgwUsers.DataSource = Program.usersBL.GetList().ToList();
                    if (Program.rewardsBL.indexOfReward == Program.rewardsBL.GetList().Count())
                        Program.rewardsBL.indexOfReward = 0;
                    tbTitle.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Title;
                    tbDescription.Text = Program.rewardsBL.GetList().ToList()[Program.rewardsBL.indexOfReward].Description;
                    main.dgwRewards.DataSource = Program.rewardsBL.GetList().ToList();
                }
                else
                {
                    Program.rewardsBL.Delete();
                    MainForm main = this.Owner as MainForm;
                    main.dgwUsers.DataSource = Program.usersBL.GetList().ToList();
                    this.btnDelete.Enabled = false;
                    main.btnEditRewards.Enabled = false;
                    this.Close();
                }
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (tbTitle.Text == string.Empty)
            {
                errorProvider1.SetError(tbTitle, "Строка не должна быть пустой");
                e.Cancel = true;
            }
        }
    }
}
