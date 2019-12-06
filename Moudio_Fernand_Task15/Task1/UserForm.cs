using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class UserForm : Form
    {
        private readonly bool _createNew = true;
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(User user)
        {
            InitializeComponent();

            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Birthdate = user.Birthdate;

            _createNew = false;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            textUserID.Text = ID.ToString();
            textUserFirstName.Text = FirstName;
            textUserLastName.Text = LastName;
            dateTimePicker1.Text = Birthdate.ToShortTimeString();

            if (_createNew)
            {
                Text = "Registration of a new student";
                btnUserOK.Text = "Create";
            }
            else
            {
                Text = "Editing user record";
                btnUserOK.Text = "Update";
            }
        }

        private void btnUserOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void textUserFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = textUserFirstName.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(textUserFirstName, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textUserFirstName, String.Empty);
                e.Cancel = false;
            }
        }

        private void textUserFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = textUserFirstName.Text.Trim();
        }

        private void textUserLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = textUserLastName.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(textUserLastName, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textUserLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void textUserLastName_Validated(object sender, EventArgs e)
        {
            LastName = textUserLastName.Text.Trim();
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            Birthdate = dateTimePicker1.Value;
        }

        private void textUserID_Validating(object sender, CancelEventArgs e)
        {
            string input = textUserID.Text.Trim();
            int value;
            if (String.IsNullOrEmpty(input) || (!Int32.TryParse(input, out value)))
            {
                errorProvider.SetError(textUserID, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textUserID, String.Empty);
                e.Cancel = false;
            }
        }

        private void textUserID_Validated(object sender, EventArgs e)
        {
            string value = textUserID.Text;
            ID = Int32.Parse(value);

        }
    }
}
