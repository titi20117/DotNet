using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        enum UserSortMode
        {
            Ascending,
            Descending
        };

        private UserSortMode _sortMode = UserSortMode.Ascending;
        private BindingList<User> _users = new BindingList<User>();
        private BindingList<Awards> _awards = new BindingList<Awards>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _users.Add(new User() { ID = 1, FirstName = "Antoinette Charlotte", LastName = "Agoume Moudio", Birthdate = new DateTime(1983, 02, 26) });
            _users.Add(new User() { ID = 2, FirstName = "Jean Pierre", LastName = "Njoli Moudio", Birthdate = new DateTime(1984, 09, 06) });
            _users.Add(new User() { ID = 3, FirstName = "Guy Honore", LastName = "Ndeme Moudio", Birthdate = new DateTime(1986, 09, 08) });
            _users.Add(new User() { ID = 4, FirstName = "Fernand Elisee", LastName = "Moudio Moudio", Birthdate = new DateTime(1992, 01, 22) });
            _users.Add(new User() { ID = 5, FirstName = "Vanessa", LastName = "Mouli Moudio", Birthdate = new DateTime(1993, 09, 10) });
            _users.Add(new User() { ID = 6, FirstName = "Marie Elisabeth", LastName = "Moudio Imondi", Birthdate = new DateTime(1997, 10, 27) });
            _users.Add(new User() { ID = 7, FirstName = "Charles Rene", LastName = "Moudio Moudio", Birthdate = new DateTime(2002, 03, 20) });
            _users.Add(new User() { ID = 8, FirstName = "Maroufatou", LastName = "Adamou Moudio", Birthdate = new DateTime(1999, 08, 26) });

            _awards.Add(new Awards() 
            { 
                ID = 1, 
                Title = "Ashok Chakra", 
                Description = "The Ashok Chakra is an " +
                "Indian military decoration awarded for valour, courageous action" });
            _awards.Add(new Awards()
            {
                ID = 2,
                Title = "Arjuna Award",
                Description = "The award given by the government of India to recognise outstanding achievement in National sports."
            });
            _awards.Add(new Awards()
            {
                ID = 3,
                Title = "Param Vir Chakra",
                Description = "It is the highest award for military services"
            });
            _awards.Add(new Awards()
            {
                ID = 4,
                Title = "Padma Bhushan",
                Description = "It is to recognize distinguished service of a high order to the nation"
            });
            SortUsersByFirstNameAsc();
            ctlUsers.DataSource = _users;
            ctlAwards.DataSource = _awards;
        }

        private void SortUsersByFirstNameAsc()
        {
            _users = new BindingList<User>(_users.OrderBy(s => s.FirstName).ToList());
        }
        private void SortUsersByFirstNameDesc()
        {
            _users = new BindingList<User>(_users.OrderByDescending(s => s.FirstName).ToList());
        }

        private void ctlFileInsert_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void RegisterNewUser()
        {
            UserForm form = new UserForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                User user = new User();
                user.ID = form.ID;
                user.FirstName = form.FirstName;
                user.LastName = form.LastName;
                user.Birthdate = form.Birthdate;

                _users.Add(user);
            }
        }

        private void ctlFileEdit_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void EditSelectedUser()
        {
            if(ctlUsers.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                UserForm form = new UserForm(user);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    user.ID = form.ID;
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.Birthdate = form.Birthdate;
                }
            }
        }

        private void ctlFileRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedUser();
        }

        private void RemoveSelectedUser()
        {
            if(ctlUsers.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;
                _users.Remove(user);
            }
        }

        private void ctlFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
