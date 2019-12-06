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
    public partial class UserAwardForm : Form
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        private User user = new User();

        private BindingList<Awards> _userAwards = new BindingList<Awards>();

        public UserAwardForm()
        {
            InitializeComponent();
        }

        public UserAwardForm(BindingList<Awards> awards, BindingList<User> list)
        {
            InitializeComponent();
            BindingList<Awards> userListAward = new BindingList<Awards>();
            //userListAward = list.Select(user.ListAward);
            //list.Where(user => user.ListAward.Where(award => award.ID == 1))
            //dgvUserAward.DataSource = awards;
            dgvUserAward.DataSource = list;
            dgvListAward.DataSource = awards;
        }
        private void UserAwardForm_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Select";
            chkbox.Width = 25;
            chkbox.Name = "DGVchkBox";
            chkbox.DefaultCellStyle.BackColor = Color.Red;
            dgvListAward.Columns.Insert(0, chkbox);
        }

        private void btnUserAwardAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            foreach(DataGridViewRow drv in dgvListAward.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["DGVchkBox"].Value);
                if(chkboxselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value);
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dgvUserAward.DataSource = dt;
            }
        }

        private void btnUserAwardOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
    }
}
