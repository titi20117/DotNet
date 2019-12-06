using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace Department.DAL
{
    public class UsersBdDAO: IUsersDAO
    {
        private List<Users> users = new List<Users>();
        private SqlConnection connection;
        public UsersBdDAO()
        {
            connection = InitConnectionUsersRewards.InitConnection();
        }
        public void Add(Users user)
        {
            if (user == null)
                throw new ArgumentException("student");
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                //command.Parameters.AddWithValue("@idUser", user.ID);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                command.ExecuteNonQuery();
            }

            connection.Close();
            users.Add(user);
            AddReward(user.ID,user.Rewards);
        }

        public void Delete(int index)
        {
            int id = users[index].ID;
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@idUser", id);
                command.ExecuteNonQuery();

            }

            connection.Close();
            GetList();
        }
        public void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string rewards)
        {
            int id = users[indexOfUser].ID;
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdatePersonByID";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@idUser", id);
                command.Parameters.AddWithValue("@newFirstName", firstName);
                command.Parameters.AddWithValue("@newLastName", lastName);
                command.Parameters.AddWithValue("@newBirthdate", birthdate);
                command.ExecuteNonQuery();
            }
            connection.Close();
            AddReward(id, rewards);
            users[indexOfUser].FirstName = firstName;
            users[indexOfUser].LastName = lastName;
            users[indexOfUser].Birthdate = birthdate;
            users[indexOfUser].Rewards = rewards;
        }
        public IEnumerable<Users> GetList()
        {
            List<int> valuesOfRewards = new List<int>();
            RewardsBdDAO rewards = new RewardsBdDAO();
            string title=string.Empty;
            connection.Open();
            users.Clear();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Users", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetDateTime(3));
                    users.Add(user);
                }
                reader.Close();
            }
            connection.Close();
            for (int i=0;i<users.Count();i++)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT AwardId FROM UsersAndAwards WHERE UserId = {users[i].ID}", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        valuesOfRewards.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                }
                    connection.Close();
                    for (int j = 0; j < valuesOfRewards.Count(); j++)
                    {
                        for (int k = 0; k < rewards.GetList().Count(); k++)
                        {
                            if (rewards.GetList().ToList()[k].ID == valuesOfRewards[j])
                            {
                                title = rewards.GetList().ToList()[k].Title;
                            }
                        }
                        users[i].Rewards = users[i].Rewards + " " + title;
                    }
                    valuesOfRewards.Clear();
                
            }
            
            return users;
        }
        public void AddReward(int idUser, string reward)
        {
            RewardsBdDAO rewardsBd = new RewardsBdDAO();
            List<int> rewardsOfUser = new List<int>();
            for (int i = 0; i < rewardsBd.GetList().Count(); i++)
            {
                if (reward.Contains(rewardsBd.GetList().ToList()[i].Title))
                {
                    rewardsOfUser.Add(rewardsBd.GetList().ToList()[i].ID);
                }
            }
            connection.Open();
            for (int i = 0; i < rewardsOfUser.Count(); i++)
            {
                using (var command = new SqlCommand())
                {
                    command.CommandText = "AddRewardForUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUser", idUser);
                    command.Parameters.AddWithValue("@idReward", rewardsOfUser[i] );
                    command.ExecuteNonQuery();
                }
                
            }
            connection.Close();
        }
        public void DeleteReward(int indexOfUser, string reward)
        {
            users[indexOfUser].Rewards = users[indexOfUser].Rewards.Replace(reward, "");
        }
    }
}
