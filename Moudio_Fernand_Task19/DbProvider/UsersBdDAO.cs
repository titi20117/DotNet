using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DbProvider
{
    public class UsersBdDAO : IUsersDAO
    {
        private SqlConnection connection;
        private List<Users> users = new List<Users>();

        public UsersBdDAO()
        {
            connection = InitConnectionUsersAwards.InitConnection();
        }
        public void Add(Users user)
        {
            if (user == null)
                throw new ArgumentException("userBd");
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Birthdate", user.BirthDate);

                command.ExecuteNonQuery();
            }

            connection.Close();
            users.Add(user);
            AddAward(user.Id, user.Awards);
        }

        public void AddAward(int indexOfUser, string award)
        {
            AwardsBdDAO awardsBd = new AwardsBdDAO();
            List<int> awardsOfUser = new List<int>();
            for (int i = 0; i < awardsBd.GetList().Count(); i++)
            {
                if (award.Contains(awardsBd.GetList().ToList()[i].Title))
                {
                    awardsOfUser.Add(awardsBd.GetList().ToList()[i].Id);
                }
            }
            connection.Open();
            for (int i = 0; i < awardsOfUser.Count(); i++)
            {
                using (var command = new SqlCommand())
                {
                    command.CommandText = "AddRewardForUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idUser", indexOfUser);
                    command.Parameters.AddWithValue("@idReward", awardsOfUser[i]);
                    command.ExecuteNonQuery();
                }

            }
            connection.Close();
        }

        public void Delete(int index)
        {
            int id = users[index].Id;
            connection.Open();

            using(var command = new SqlCommand())
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

        public void DeleteAward(int indexOfUser, string award)
        {
            users[indexOfUser].Awards = users[indexOfUser].Awards.Replace(award, "");
        }

        public void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string awards)
        {
            int id = users[indexOfUser].Id;
            connection.Open();
            using(var command = new SqlCommand())
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
            AddAward(id, awards);
            users[indexOfUser].FirstName = firstName;
            users[indexOfUser].LastName = lastName;
            users[indexOfUser].BirthDate = birthdate;
            users[indexOfUser].Awards = awards;
        }

        public IEnumerable<Users> GetList()
        {
            List<int> valuesOfAwards = new List<int>();
            AwardsBdDAO awards = new AwardsBdDAO();
            string title = string.Empty;
            connection.Open();
            users.Clear();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Users", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                    users.Add(user);
                }
                reader.Close();
            }
            connection.Close();
            for (int i = 0; i < users.Count(); i++)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT AwardId FROM UsersAndAwards WHERE UserId = {users[i].Id}", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        valuesOfAwards.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                }
                connection.Close();
                for (int j = 0; j < valuesOfAwards.Count(); j++)
                {
                    for (int k = 0; k < awards.GetList().Count(); k++)
                    {
                        if (awards.GetList().ToList()[k].Id == valuesOfAwards[j])
                        {
                            title = awards.GetList().ToList()[k].Title;
                        }
                    }
                    users[i].Awards = users[i].Awards + "\n" + title;
                }
                valuesOfAwards.Clear();

            }

            return users;
        }
    }
}
