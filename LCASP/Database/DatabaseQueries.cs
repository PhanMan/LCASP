using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace Lcasp
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
            theConnection.Close();

            return theList;
        }

        public void DeleteArcher(int a_id)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("delete from archers where archer_id = " + a_id, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
        }


        public void DeleteSchool(int s_id)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("delete from schools where school_id = " + s_id, theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
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
                                                  theReader["archer_sex"].ToString());

                    theList.Add(theArcher);
                }
            }

            theReader.Close();
            theConnection.Close();

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
                                                  theReader["archer_sex"].ToString());

                    retArcher = theArcher;
                }
            }

            theReader.Close();
            theConnection.Close();

            return retArcher;
        }


        public void StartNewMeet()
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("truncate table archer_data", theConnection);

            int result = (int)theCmd.ExecuteNonQuery();

            theConnection.Close();
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
            try
            {
                SqlConnection theConnection = new SqlConnection("Data Source = localhost\\sqlexpress; initial catalog=master; Integrated Security = True");
                theConnection.Open();
                SqlCommand checkCmd = new SqlCommand("select count(*) from sysdatabases where name = 'lcasp'",theConnection);
                int num = (int)checkCmd.ExecuteScalar();

                if (num == 0)
                {
                    string script = File.ReadAllText(@"script.sql");

                    // split script on GO command
                    IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                             System.Text.RegularExpressions.RegexOptions.Multiline | RegexOptions.IgnoreCase);


                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, theConnection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                theConnection.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
