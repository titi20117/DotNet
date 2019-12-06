using System;
using System.Collections.Generic;
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
        private BindingList<Awards> _userAwards = new BindingList<Awards>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _awards.Add(new Awards()
            {
                ID = 1,
                Title = "Ashok Chakra",
                Description = "The Ashok Chakra is an " +
                "Indian military decoration awarded for valour, courageous action"
            });
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
            
            
            _users.Add(new User()
            {
                ID = 1,
                FirstName = "Antoinette Charlotte",
                LastName = "Agoume Moudio",
                Birthdate = new DateTime(1983, 02, 26),
                ListAward = new BindingList<Awards> { _awards[0], _awards[1]}
            });
               
            _users.Add(new User() 
            { 
                ID = 2, 
                FirstName = "Jean Pierre", 
                LastName = "Njoli Moudio", 
                Birthdate = new DateTime(1984, 09, 06),
                //ListAward = _awards.Where(award => award.ID == 2).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 3, 
                FirstName = "Guy Honore", 
                LastName = "Ndeme Moudio", 
                Birthdate = new DateTime(1986, 09, 08),
                //ListAward = _awards.Where(award => award.ID == 1 ||award.ID == 2).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 4, 
                FirstName = "Fernand Elisee", 
                LastName = "Moudio Moudio", 
                Birthdate = new DateTime(1992, 01, 22),
                //ListAward = _awards.Where(award => award.ID == 3).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 5, 
                FirstName = "Vanessa", 
                LastName = "Mouli Moudio", 
                Birthdate = new DateTime(1993, 09, 10),
                //ListAward = _awards.Where(award => award.ID == 1).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 6, 
                FirstName = "Marie Elisabeth", 
                LastName = "Moudio Imondi", 
                Birthdate = new DateTime(1997, 10, 27),
                //ListAward = _awards.Where(award => award.ID == 4).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 7, 
                FirstName = "Charles Rene", 
                LastName = "Moudio Moudio", 
                Birthdate = new DateTime(2002, 03, 20),
                //ListAward = _awards.Where(award => award.ID == 2).ToList()
            });
            _users.Add(new User() 
            { 
                ID = 8, 
                FirstName = "Maroufatou", 
                LastName = "Moudio", 
                Birthdate = new DateTime(1999, 08, 26),
                //ListAward = _awards.Where(award => award.ID == 1).ToList()
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

        private void ctlFileInsertUser_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void ctlFileInsertAward_Click(object sender, EventArgs e)
        {
            RegisterNewAward();
        }

        private void RegisterNewAward()
        {
            AwardForm form = new AwardForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Awards award = new Awards();
                award.ID = form.ID;
                award.Title = form.Title;
                award.Description = form.Description;

                _awards.Add(award);
            }
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
            if(ctlAwards.SelectedRows.Count > 0)
            {
                Awards award = (Awards)ctlAwards.SelectedCells[0].OwningRow.DataBoundItem;
                AwardForm form = new AwardForm(award);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    award.ID = form.ID;
                    award.Title = form.Title;
                    award.Description = form.Description;
                }
            }
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
            if (ctlAwards.SelectedCells.Count > 0)
            {
                Awards award = (Awards)ctlAwards.SelectedCells[0].OwningRow.DataBoundItem;
                _awards.Remove(award);
            }
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

        private void ctlUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex == 0)
            {
                ShowUserAwards();
            }
        }

        private void ShowUserAwards()
        {
            List<Awards> list = new List<Awards>();
            
            UserAwardForm userAwardForm = new UserAwardForm(_awards, _users);
            userAwardForm.Show();
            Awards award = new Awards();
            award.ID = userAwardForm.ID;
            award.Title = userAwardForm.Title;
            award.Description = userAwardForm.Description;
            //if (userAwardForm.ShowDialog(this) == DialogResult.OK) { }assouma 
        }
    }
}
