using Iti.Bll.Models;
using ITI.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iti.Bll
{
    public class TopicBL
    {
        DbContext _dbContext;
        public TopicBL()
        {
            _dbContext = new DbContext();

        }
        public DataTable GetAllV1()
        {
            string command = "select * from Topic";

            return _dbContext.GetData(command);
        }

        public List<Topic> GetAllV2()
        {
            string command = "select * from Topic";
            DataTable dataTable = _dbContext.GetData(command);
            List<Topic> topics = new List<Topic>();

            foreach (DataRow item in dataTable.Rows)
            {
                topics.Add(new Topic()
                {
                    Id = (int)item["Top_Id"],

                    Name = item["Top_Name"].ToString(),
                });
            }

            return topics;
        }
        public DataTable GetById(int id)
        {
            string command = $"select * from Topic where Top_Id = {id}";

            return _dbContext.GetData(command);
        }
        public Topic GetTopicById(int id)
        {
            string command = $" select * from Topic where Top_Id= {id}";

            DataTable dataTable = _dbContext.GetData(command);
            Topic topicS = new Topic()
            {
                Id = (int)dataTable.Rows[0]["Top_id"],
                Name = dataTable.Rows[0]["Top_Name"].ToString()
            };
            return topicS;

        }

        //edite
        public int Update(int id,string name)
        {
            string command = "UPDATE Topic SET Top_Name = @name WHERE Top_id = @id";

            SqlParameter[] sqlParameters = new SqlParameter[2];    // Change the size to 1
                                                                 
            sqlParameters[0] = new SqlParameter("@name", name);    // Correct parameter name and value
                                                                 
            sqlParameters[1] = new SqlParameter("@id", id);    // Correct parameter name and value
         
            return _dbContext.ExecuteNonQuery(command, sqlParameters);
        }

        //add
        public int Insert(string name)
        {
            string command = "insert into Topic values(@name)";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("name", name);
            return _dbContext.ExecuteNonQuery(command, sqlParameters);
        }
        //delete
        public int delete(int id)
        {
            string command = "delete from Topic where Top_id = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id", id);


            return _dbContext.ExecuteNonQuery(command, sqlParameters);
        }
        


    }
}
