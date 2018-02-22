using System;
using System.Collections.Generic;
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

        public List<KeyValuePair<int, string>> GetParticipatingSchoolList(Boolean showAllShooters)
        {
            List<KeyValuePair<int, string>> theList = new List<KeyValuePair<int, string>>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "";
            
            if(showAllShooters)
                cmd = "Select school_id, school_name from schools where school_id in (select distinct school_id from archers)";
            else
                cmd = "Select school_id, school_name from schools where school_id in (select distinct (a.school_id) from archers a, archer_data ad where a.archer_id = ad.archer_id)";

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

        public int GetArcherID(int a_aims_id)
        {
            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand("select archer_id from archers where archer_state_id = " + a_aims_id, theConnection);

            int a_id = (int)theCmd.ExecuteScalar();

            theConnection.Close();
            return a_id;

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

        public List<Archer> GetSchoolArcher(int s_id, int a_id, string form)
        {
            List<Archer> theList = new List<Archer>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "Select * from archers where school_id = " + s_id + " and archer_id = " + a_id + " order by archer_id asc";


            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    Archer theArcher = new Archer(s_id,
                                                  Convert.ToInt32(theReader["archer_id"].ToString()),
                                                  Convert.ToInt32(theReader["archer_state_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString(),
                                                  form);

                    theList.Add(theArcher);
                }
            }

            theReader.Close();
            theConnection.Close();

            return theList;
        }

        public List<Archer> GetSchoolArchers(int s_id, string form)
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
                                                  Convert.ToInt32(theReader["archer_state_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString(),
                                                  form);

                    theList.Add(theArcher);
                }
            }

            theReader.Close();
            theConnection.Close();

            return theList;
        }

        public List<string> GetAllParticipatingArchers()
        {
            List<string> theList = new List<string>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = 
            "Select distinct(a.archer_id), ad.archer_data_id, a.archer_state_id, a.archer_name, a.archer_sex, a.school_id, ad.archer_raw_data, ad.archer_score " +
            "from archers a, archer_data ad " +
            "where " +
            "a.archer_id = ad.archer_id and " +
            "ad.archer_data_id = (SELECT " +
            "MAX(ad.archer_data_id) " +
            "FROM archer_data ad where ad.archer_id = a.archer_id) " +
            "order by ad.archer_score desc";
            
           // cmd = "Select distinct(a.archer_id), a.archer_state_id, a.archer_name, a.archer_sex, a.school_id, ad.archer_raw_data, ad.archer_score from archers a, archer_data ad where a.archer_id = ad.archer_id and max(ad.archer_data_id) order by ad.archer_score desc";

            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    string dataLine = theReader["archer_raw_data"].ToString();

                    /*
                    Archer theArcher = new Archer(Convert.ToInt32(theReader["school_id"].ToString()),
                                                  Convert.ToInt32(theReader["archer_id"].ToString()),
                                                  Convert.ToInt32(theReader["archer_state_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString(),
                                                  "XXXX");
                                                  */
                    theList.Add(dataLine);
                }
            }

            theReader.Close();
            theConnection.Close();

            return theList;
        }

        public List<Archer> GetParticipatingSchoolArchers(Boolean allShooters, int s_id, string form)
        {
            List<Archer> theList = new List<Archer>();

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            string cmd = "";

            if(allShooters)
            {
                cmd = "Select distinct(a.archer_id), a.archer_state_id, a.archer_name, a.archer_sex from archers a where school_id = " + s_id + " order by a.archer_id asc";
            }
            else
            {
                cmd = "Select distinct(a.archer_id), a.archer_state_id, a.archer_name, a.archer_sex from archers a, archer_data ad where a.archer_id = ad.archer_id and school_id = " + s_id + " order by a.archer_id asc";
            }


            SqlCommand theCmd = new SqlCommand(cmd, theConnection);

            SqlDataReader theReader = theCmd.ExecuteReader();

            if (theReader.HasRows)
            {
                while (theReader.Read())
                {
                    Archer theArcher = new Archer(s_id,
                                                  Convert.ToInt32(theReader["archer_id"].ToString()),
                                                  Convert.ToInt32(theReader["archer_state_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString(),
                                                  form);

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
                                                  Convert.ToInt32(theReader["archer_state_id"].ToString()),
                                                  theReader["archer_name"].ToString(),
                                                  theReader["archer_sex"].ToString(),
                                                  "XXXX");

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
                    theCmd.CommandText = "select top 1 archer_data_id from archer_data where archer_id = " + scoreData.ArcherID + " order by archer_data_id desc";

                    int id = (int)theCmd.ExecuteScalar();

                    scoreData.ArcherDataID = id;
                }
                else
                {
                    scoreData.ArcherDataID = -1;
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

        public void AddArcher(string a_name, int aims_id, string a_sex, int s_id)
        {
            string sql = "insert into archers (school_id, archer_state_id, archer_name, archer_sex) " +
             " values " +
             "(" + s_id + ", " + aims_id + ", '" + a_name + "', '" + a_sex + "'); SELECT CAST(scope_identity() AS int);";

            SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(sql, theConnection);

            int result = (int)theCmd.ExecuteScalar();


            if(aims_id == 0 && result != 0)
            {
                string updateStr = "Update archers set archer_state_id = " + result.ToString() + " where archer_id = " + result.ToString();

                SqlCommand cmd = new SqlCommand(updateStr, theConnection);

                cmd.ExecuteNonQuery();
            }

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
                    retData = new ArcherData(theReader["archer_raw_data"].ToString())
                    {
                        ArcherDataID = Convert.ToInt32(theReader["archer_data_id"].ToString())
                    };
                }
            }

            theConnection.Close();
            return retData;
        }

        public void CheckDatabaseVersion()
        {
            string sql = "select database_version from lcasp_version";

           SqlConnection theConnection = new SqlConnection(connectionString);

            theConnection.Open();

            SqlCommand theCmd = new SqlCommand(sql, theConnection);

            int result = 0;

            try
            {
                result = (int)theCmd.ExecuteScalar();
            }
            catch (Exception)
            {
                DropDatabase();
                CreateDatabase();
            }

            theConnection.Close();

            if(result != Properties.Settings.Default.DataVersion)
            {
                DropDatabase();

                CreateDatabase();
            }
        }

        public void DropDatabase()
        {
            try
            {
                SqlConnection theConnection = new SqlConnection("Data Source = localhost\\sqlexpress; initial catalog=master; Integrated Security = True");
                theConnection.Open();

                string script = File.ReadAllText(@"drop.sql");

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

                theConnection.Close();
            }
            catch (Exception)
            {
            }
        }

        public void RestoreDatabase(string backupFileName)
        {
            var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);
            string backupFolder = Properties.Settings.Default.DatabaseBackup;

            // set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
            //var backupFileName = String.Format("{0}{1}-{2}.bak",
            //    backupFolder, sqlConStrBuilder.InitialCatalog,
            //    DateTime.Now.ToString("yyyy-MM-dd"));

            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                //RESTORE DATABASE[data] FROM DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Backup\data.bak' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10
                var query = String.Format("RESTORE DATABASE {0} FROM DISK='{1}'",
                    sqlConStrBuilder.InitialCatalog, backupFileName);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BackupDatabase()
        {
            var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);
            string backupFolder = Properties.Settings.Default.DatabaseBackup; 

            // set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
            var backupFileName = String.Format("{0}{1}-{2}.bak",
                backupFolder, sqlConStrBuilder.InitialCatalog,
                DateTime.Now.ToString("yyyy-MM-dd"));

            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                    sqlConStrBuilder.InitialCatalog, backupFileName);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateDatabase()
        {
            try
            {
                if (!Directory.Exists(Properties.Settings.Default.DatabaseBackup))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.DatabaseBackup);
                }

                SqlConnection theConnection = new SqlConnection("Data Source = localhost\\sqlexpress; initial catalog=master; Integrated Security = True");
                theConnection.Open();
                SqlCommand checkCmd = new SqlCommand("select count(*) from sysdatabases where name = 'lcasp'", theConnection);
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
