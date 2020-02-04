using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DbProvider
{
    public class AwardsBdDAO : IAwardsDAO
    {
        private SqlConnection connection;
        private List<Awards> awards = new List<Awards>();
        private List<Awards> Empty = new List<Awards>();

        public AwardsBdDAO()
        {
            connection = InitConnectionUsersAwards.InitConnection();
        }
        public void Add(Awards award)
        {
            if (award == null)
                throw new ArgumentException("awardBd");
            connection.Open();

            using(var command = new SqlCommand())
            {
                command.CommandText = "AddReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Name", award.Title);
                command.Parameters.AddWithValue("@Description", award.Description);
                
                command.ExecuteNonQuery();
            }

            connection.Close();
            awards.Add(award);
        }

        public string AwardAt(int indexOfAward)
        {
            return awards[indexOfAward].Title;
        }

        public void Delete(int index)
        {
            string title = awards[index].Title;
            int id = awards[index].Id;
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@idAward", id);
                //command.Parameters.AddWithValue("@Title", title);

                command.ExecuteNonQuery();
            }
            connection.Close();
            GetList();
        }

        public void Edit(int indexOfAwards, string title, string description)
        {
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateAwardsById";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Id", awards[indexOfAwards].Id);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }
            connection.Close();
            awards[indexOfAwards].Title = title;
            awards[indexOfAwards].Description = description;
        }

        public IEnumerable<Awards> GetEmpty()
        {
            return Empty;
        }

        public IEnumerable<Awards> GetList()
        {
            connection.Open();
            awards.Clear();
            using(var command = new SqlCommand("SELECT * FROM Awards", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Awards award = new Awards(reader.GetInt32(0), reader.GetString(1), reader[2]?.ToString());
                    awards.Add(award);
                }
                reader.Close();
            }
            connection.Close();
            return awards;
        }
    }
}
