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
    public class RewardsBdDAO: IRewardsDAO
    {
        private SqlConnection connection;
        private List<Rewards> rewards = new List<Rewards>();
        private List<Rewards> Empty = new List<Rewards>();

        public RewardsBdDAO()
        {
            connection = InitConnectionUsersRewards.InitConnection();
        }
        public void Add(Rewards reward)
        {
            if (reward == null)
                throw new ArgumentException("student");
            connection.Open();

            using (var command = new SqlCommand())
            {
                command.CommandText = "AddReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                //command.Parameters.AddWithValue("@idAward", reward.ID);
                command.Parameters.AddWithValue("@Name", reward.Title);
                command.Parameters.AddWithValue("@Description", reward.Description);

                command.ExecuteNonQuery();
            }

            connection.Close();

            rewards.Add(reward);
        }
        public void Delete(int index)
        {
            string title = rewards[index].Title;
            int id = rewards[index].ID;
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@idReward", id);
                command.Parameters.AddWithValue("@Title", title) ;


                command.ExecuteNonQuery();
                
            }
            
            connection.Close();
            GetList();
            
        }
        
        public void Edit(int indexOfRewards, string title, string description)
        {
            connection.Open();

            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateRewardByID";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", rewards[indexOfRewards].ID);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }

            connection.Close();
            rewards[indexOfRewards].Title = title;
            rewards[indexOfRewards].Description = description;
        }
        public IEnumerable<Rewards> GetList()
        {
            connection.Open();
            rewards.Clear();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Awards", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rewards reward = new Rewards(reader.GetInt32(0), reader.GetString(1), reader[2]?.ToString());
                    rewards.Add(reward);
                }
                reader.Close();
            }
            
            connection.Close();
            return rewards;
        }
        public IEnumerable<Rewards> GetEmpty()
        {
            return Empty;
        }
        public string RewardAt(int indexOfReward)
        {
            return rewards[indexOfReward].Title;
        }
    }
}
