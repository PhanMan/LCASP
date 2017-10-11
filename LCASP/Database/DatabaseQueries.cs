using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LCASP
{
    public class DatabaseQueries
    {
        string connectionString = Properties.Settings.Default.SqlServerExpress;// .lcasp_dataConnectionString

        public void ClearDatabase()
        {
            List<KeyValuePair<int, string>> myList = GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in myList)
            {
                DeleteSchool(Convert.ToInt32(kvp.Key));
            }
        }

        public List<KeyValuePair<int, string>> GetSchoolList()
        {
            List<KeyValuePair<int, string>> theList = new List<KeyValuePair<int, string>>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "Select school_id, school_name from schools order by school_name asc";

            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    theList.Add(new KeyValuePair<int, string>(Convert.ToInt32(theReader["school_id"].ToString()), theReader["school_name"].ToString()));
                }
            }

            theReader.Close();
            theReader.Dispose();
            theCmd.Dispose();
            theConnection.Close();
            theConnection.Dispose();

            return theList;
        }

        public void DeleteArcher(int a_id)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("delete from archers where archer_id = " + a_id, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theCmd.Dispose();
            theConnection.Close();
            theConnection.Dispose();
        }


        public void DeleteSchool(int s_id)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("delete from schools where school_id = " + s_id, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theCmd.Dispose();
            theConnection.Close();
            theConnection.Dispose();
        }

        public List<Archer> GetSchoolArchers(int s_id)
        {
            List<Archer> theList = new List<Archer>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "Select * from archers where school_id = " + s_id + " order by archer_id asc";

            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    Archer theArcher = new Archer(s_id,
                                                  Convert.ToInt32(theReader["archer_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString()[0]);

                    theList.Add(theArcher);
                }
            }

            theReader.Close();
            theReader.Dispose();
            theCmd.Dispose();
            theConnection.Close();
            theConnection.Dispose();

            return theList;
        }

        public Archer GetArcher(int a_id)
        {
            Archer retArcher = null;


            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "Select * from archers where archer_id = " + a_id;

            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    Archer theArcher = new Archer(Convert.ToInt32(theReader["school_id"].ToString()),
                                                  a_id,
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString()[0]);

                    retArcher = theArcher;
                }
            }

            theReader.Close();
            theReader.Dispose();
            theCmd.Dispose();
            theConnection.Close();
            theConnection.Dispose();

            return retArcher;
        }


        public void StartNewMeet()
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("truncate table archer_data", theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
            theCmd = null;
        }


        public ArcherData SetArcherData(ArcherData scoreData)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(scoreData.GetSqlInsert(), theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            if (result == 1)
            {
                theCmd.CommandText = "select top 1 archer_data_id from archer_data where archer_id = " + scoreData.archer_id + " order by archer_data_id desc";

                int id = (int)theCmd.ExecuteScalar();

                scoreData.archer_data_id = id;
            }
            else
            {
                scoreData.archer_data_id = -1;
            }

            theConnection.Close();
            return scoreData;
        }

        public void AddSchool(string s_name)
        {
            string sql = "insert into schools (school_name) " +
                         " values " +
                         "('" + s_name + "')";

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(sql, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
        }

        public void AddArcher(string a_name, string a_sex, int s_id)
        {
            string sql = "insert into archers (school_id, archer_name, archer_sex) " +
             " values " +
             "(" + s_id + ", '" + a_name + "', '" + a_sex + "')";

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(sql, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
        }

        public ArcherData GetArcherData(int a_id)
        {
            ArcherData retData = null;
            string sql = "select top 1 archer_data_id, archer_raw_data from archer_data where archer_id = " + a_id + " order by archer_data_id desc";

            
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(sql, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    retData = new ArcherData(theReader["archer_raw_data"].ToString());

                    retData.archer_data_id = Convert.ToInt32(theReader["archer_data_id"].ToString());

                }
            }
            return retData;
        }

        public void CreateDatabase()
        {
            string line = "";

            SqlConnection theConnection = new SqlConnection("Data Source = localhost\\sqlexpress; initial catalog=master; Integrated Security = True");

            theConnection.Open();

            string sqlCheck = "select count(name) from [lcasp].sys.tables where name='schools'";

            SqlCommand theCmd = new SqlCommand(sqlCheck, theConnection);

            int result = (int)theCmd.ExecuteScalar();

            if (result == 1)
                return;

            System.IO.StreamReader file = new System.IO.StreamReader("script.sql");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    theCmd.CommandText = line;
                    theCmd.ExecuteNonQuery();
                }
            }

            theConnection.Close();
            file.Close();

        }
    }
}
