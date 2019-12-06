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
    public partial class AwardForm : Form
    {
        private readonly bool _createNew = true;
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Awards award)
        {
            InitializeComponent();
            ID = award.ID;
            Title = award.Title;
            Description = award.Description;
            _createNew = false;
        }

        private void AwardForm_Load(object sender, EventArgs e)
        {
            txtAwardID.Text = ID.ToString();
            txtAwardTitle.Text = Title;
            txtAwardDescription.Text = Description;

            if (_createNew)
            {
                Text = "Registration of a new Award";
                btnAwardOK.Text = "Create";
            }
            else
            {
                Text = "Editing Award record";
                btnAwardOK.Text = "Update";
            }
        }

        private void btnAwardOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        /// <summary>
        /// Award title validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = txtAwardTitle.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProviderAward.SetError(txtAwardTitle, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProviderAward.SetError(txtAwardTitle, String.Empty);
                e.Cancel = false;
            }
        }
        /// <summary>
        /// Award title validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardTitle_Validated(object sender, EventArgs e)
        {
            Title = txtAwardTitle.Text.Trim();
        }
        /// <summary>
        /// Description Award validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardDescription_Validating(object sender, CancelEventArgs e)
        {
            string input = txtAwardDescription.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProviderAward.SetError(txtAwardDescription, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProviderAward.SetError(txtAwardDescription, String.Empty);
                e.Cancel = false;
            }
        }
        /// <summary>
        /// Description Award validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardDescription_Validated(object sender, EventArgs e)
        {
            Description = txtAwardDescription.Text.Trim();
        }
        /// <summary>
        /// ID Award validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardID_Validating(object sender, CancelEventArgs e)
        {
            string input = txtAwardID.Text.Trim();
            int value;
            if (String.IsNullOrEmpty(input) || (!Int32.TryParse(input, out value)))
            {
                errorProviderAward.SetError(txtAwardID, "value is not correct");
                e.Cancel = true;
            }
            else
            {
                errorProviderAward.SetError(txtAwardID, String.Empty);
                e.Cancel = false;
            }
        }
        /// <summary>
        /// ID Award validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAwardID_Validated(object sender, EventArgs e)
        {
            string value = txtAwardID.Text;
            ID = Int32.Parse(value);
        }
    }
}