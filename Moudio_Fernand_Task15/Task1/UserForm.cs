using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAwards.BLL;

namespace Task1
{
    public partial class UserForm : Form
    {
        private User currentUser;
        private readonly AwardsBL awardsBL;
        private readonly AwardingUsersBL awardingUsersBL;
        public string FirstName { get { return UserFirstNameBox.Text; } }
        public string LastName { get { return UserLastNameBox.Text; } }
        public DateTime BirthDay { get { return dateTimePicker1.Value; } }
        public UserForm()
        {
            awardsBL = new AwardsBL();
            awardingUsersBL = new AwardingUsersBL();
            InitializeComponent();
            cbBoxAwards.Enabled = false;
            btnAddUserAward.Enabled = false;
            btnDeleteUserAward.Enabled = false;
        }

        public UserForm(User user)
        {
            awardsBL = new AwardsBL();
            awardingUsersBL = new AwardingUsersBL();
            InitializeComponent();
            this.currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            UserFirstNameBox.Text = currentUser.FirstName;
            UserLastNameBox.Text = currentUser.LastName;
            dateTimePicker1.Value = currentUser.Birthdate;
            cbBoxAwards.DataSource = awardsBL.GetAwardIdList();
        }

        private void btnUserOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddUserAward_Click(object sender, EventArgs e)
        {
            bool flag = awardingUsersBL.CheckAwardId(currentUser.ID, Int32.Parse(cbBoxAwards.Text));
            if (flag == true)
            {
                awardingUsersBL.AddAwardForUser(currentUser.ID, Int32.Parse(cbBoxAwards.Text));
            }
            else
            {
                MessageBox.Show("This award is already given!");
            }
        }

        private void BtnDeleteUserAward_Click(object sender, EventArgs e)
        {
            awardingUsersBL.RemoveAwardFromUser(currentUser.ID, Int32.Parse(cbBoxAwards.Text));
        }
    }
}
