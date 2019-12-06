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

namespace Task1
{
    public partial class AwardForm : Form
    {
        private Awards currentAward;
        public string Title { get { return txtAwardTitle.Text; } }
        public string Description { get { return txtAwardDescription.Text; } }
        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Awards award)
        {
            InitializeComponent();
            this.currentAward = award;
            txtAwardTitle.Text = currentAward.Title;
            txtAwardDescription.Text = currentAward.Description;
        }

        private void btnAwardOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnAwardCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}