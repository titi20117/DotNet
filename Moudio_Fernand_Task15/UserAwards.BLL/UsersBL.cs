using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAwards.DAL;

namespace UserAwards.BLL
{
    public class UsersBL
    {
        private readonly IUserModel userModel;
        private readonly AwardingUsersBL awardingBL;
        public UsersBL(IUserModel userModel)
        {
            this.userModel = userModel;
            awardingBL = new AwardingUsersBL();
        }
        private static int StartUserId;
        public IEnumerable<User> GetList()
        {
            return userModel.GetList();
        }
        public User GetUserById(int Id)
        {
            User CurrentUser = userModel.GetUserById(Id);
            return CurrentUser;
        }
        public void CreateNewUser(string FirstName, string LastName, DateTime Birthdate)
        {
            User TargetUser = new User();
            TargetUser.ID = StartUserId += 1;
            TargetUser.FirstName = FirstName;
            TargetUser.LastName = LastName;
            TargetUser.Birthdate = Birthdate;
            TargetUser.ListAward = new List<int>();
            userModel.Add(TargetUser);
        }
        public void EditCurrentUser(string FirstName, string LastName, DateTime Birthdate, User CurrentUser)
        {
            CurrentUser.FirstName = FirstName;
            CurrentUser.LastName = LastName;
            CurrentUser.Birthdate = Birthdate;
            CurrentUser.ListAward = awardingBL.GetUserAwardByUserId(CurrentUser.ID);

        }

        public void DeleteCurrentUser(int Id)
        {
            userModel.RemoveById(Id);
        }

        public void RemoveAwardFromUserById(List<int> listUserIdFromAwardId, int awardId)
        {
            int i = 0;
            int tempId = listUserIdFromAwardId[i];
            foreach (var item in userModel.GetList())
            {
                if (item.ID == tempId)
                {
                    item.ListAward.Remove(awardId);
                }
                i++;
            }
        }
    }
}
