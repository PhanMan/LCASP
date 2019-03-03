using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace Lcasp
{
    public class DatabaseQueries
    {
        //private string dbFileOne = "C:\\Program Files\\Microsoft SQL Server\\MSSQL11.SQLEXPRESS\\MSSQL\\DATA\\LCASP.mdf";
        //private string dbFileTwo = "C:\\Program Files\\Microsoft SQL Server\\MSSQL11.SQLEXPRESS\\MSSQL\\DATA\\LCASP.ldf";

        string connectionString = Properties.Settings.Default.SqlServerExpress;// .lcasp_dataConnectionString

        public DatabaseQueries()
        {
        }

        public void Close()
        {
        }

        public void ClearDatabase()
        {
            List<KeyValuePair<int, string>> myList = GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in myList)
            {
                DeleteSchool(Convert.ToInt32(kvp.Key));
            }
        }

        public string GetSchoolName(int school_id)
        {
            string schoolName = "";

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;
                    sqlCmd.CommandText = "Select school_name from schools where school_id = " + school_id.ToString();

                    schoolName = (string)sqlCmd.ExecuteScalar();

                    return schoolName;
                }
            }
        }

        public int GetArcherSortingFactor(int archer_id, int section)
        {
            ArcherData ad = GetArcherData(archer_id);

            switch (section)
            {
                case 10:
                    return ad.ArcherTens;

                case 9:
                    return ad.ArcherNines;

                case 8:
                    return ad.ArcherEights;

                case 7:
                    return ad.ArcherSevens;

                case 6:
                    return ad.ArcherSixes;

                default:
                    return 0;
            }
        }


        public List<KeyValuePair<int, string>> GetSchoolList()
        {
            List<KeyValuePair<int, string>> theList = new List<KeyValuePair<int, string>>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;
                    sqlCmd.CommandText = "Select school_id, school_name from schools order by school_name asc";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
                        if (theReader.HasRows)
                        {
                            while (theReader.Read())
                            {
                                theList.Add(new KeyValuePair<int, string>(Convert.ToInt32(theReader["school_id"].ToString()), theReader["school_name"].ToString()));
                            }
                        }
                    }
                }
            }

            return theList;
        }

        public List<KeyValuePair<int, string>> GetParticipatingSchoolList(Boolean showAllShooters)
        {
            List<KeyValuePair<int, string>> theList = new List<KeyValuePair<int, string>>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    if (showAllShooters)
                        sqlCmd.CommandText = "Select school_id, school_name from schools where school_id in (select distinct school_id from archers)";
                    else
                        sqlCmd.CommandText = "Select school_id, school_name from schools where school_id in (select distinct (a.school_id) from archers a, archer_data ad where a.archer_id = ad.archer_id)";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
                        if (theReader.HasRows)
                        {
                            while (theReader.Read())
                            {
                                theList.Add(new KeyValuePair<int, string>(Convert.ToInt32(theReader["school_id"].ToString()), theReader["school_name"].ToString()));
                            }
                        }
                    }
                }
            }

            return theList;
        }

        public int GetArcherID(int a_aims_id)
        {
            int archerID = 0;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connectionString))
                {
                    dbConn.Open();
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.Connection = dbConn;

                        sqlCmd.CommandText = "select archer_id from archers where archer_state_id = " + a_aims_id;

                        archerID = (int)sqlCmd.ExecuteScalar();
                    }
                }
            }
            catch(Exception)
            {
                archerID = 0;
            }

            return archerID;
        }

        public void DeleteArcher(int a_id)
        {
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "delete from archers where archer_id = " + a_id;


                    int result = (int)sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSchool(int s_id)
        {
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "delete from schools where school_id = " + s_id;

                    int result = (int)sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public List<Archer> GetSchoolArcher(int s_id, int a_id, string form)
        {
            List<Archer> theList = new List<Archer>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "Select * from archers where school_id = " + s_id + " and archer_id = " + a_id + " order by archer_id asc";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
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
                    }
                }
            }

            return theList;
        }

        public bool ArcherExists(int archer_id)
        {
            object x = null;

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "select archer_id from archers where archer_id = " + archer_id.ToString() + " or archer_state_id = " + archer_id.ToString();

                    x = sqlCmd.ExecuteScalar();
                }
            }
            if (x == null)
                return false;
            else
                return true;
        }

        public List<Archer> GetSchoolArchers(int s_id, string form)
        {
            List<Archer> theList = new List<Archer>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "Select * from archers where school_id = " + s_id + " order by archer_id asc";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
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
                    }
                }
            }
            return theList;
        }

        public List<string> GetAllParticipatingArchers()
        {
            List<string> theList = new List<string>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText =
                          "Select distinct(a.archer_id), ad.archer_data_id, a.archer_state_id, a.archer_name, a.archer_sex, a.school_id, ad.archer_raw_data, ad.archer_score " +
                          "from archers a, archer_data ad " +
                          "where " +
                          "a.archer_id = ad.archer_id and " +
                          "ad.archer_data_id = (SELECT " +
                          "MAX(ad.archer_data_id) " +
                          "FROM archer_data ad where ad.archer_id = a.archer_id) " +
                           "order by ad.archer_score desc";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
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
                    }
                }
            }
            return theList;
        }

        public List<Archer> GetParticipatingSchoolArchers(Boolean allShooters, int s_id, string form)
        {
            List<Archer> theList = new List<Archer>();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    if (allShooters)
                    {
                        sqlCmd.CommandText = "Select distinct(a.archer_id), a.archer_state_id, a.archer_name, a.archer_sex from archers a where school_id = " + s_id + " order by a.archer_id asc";
                    }
                    else
                    {
                        sqlCmd.CommandText = "Select distinct(a.archer_id), a.archer_state_id, a.archer_name, a.archer_sex from archers a, archer_data ad where a.archer_id = ad.archer_id and school_id = " + s_id + " order by a.archer_id asc";
                    }

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
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
                    }
                }
            }
            return theList;
        }

        public Archer GetArcher(int a_id)
        {
            Archer retArcher = null;

            // No archer for card scanned.
            if(a_id == 0)
                return null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connectionString))
                {
                    dbConn.Open();
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.Connection = dbConn;

                        sqlCmd.CommandText = "Select * from archers where archer_id = " + a_id;

                        using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                        {
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
                        }
                    }
                }
            }
            catch (Exception)
            {
                retArcher = null;
            }

            return retArcher;
        }

        public ArcherData SetArcherData(ArcherData scoreData)
        {
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd1 = new SqlCommand())
                {
                    sqlCmd1.Connection = dbConn;

                    sqlCmd1.CommandText = scoreData.GetSqlInsert();

                    int result = (int)sqlCmd1.ExecuteNonQuery();

                    if (result == 1)
                    {
                        using (SqlCommand sqlCmd2 = new SqlCommand())
                        {
                            sqlCmd2.Connection = dbConn;
                            sqlCmd2.CommandText = "select top 1 archer_data_id from archer_data where archer_id = " + scoreData.ArcherID + " order by archer_data_id desc";

                            int id = (int)sqlCmd2.ExecuteScalar();

                            scoreData.ArcherDataID = id;
                        }
                    }
                    else
                    {
                        scoreData.ArcherDataID = -1;
                    }

                }
            }
            return scoreData;
        }

        public void AddSchool(string s_name)
        {
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "insert into schools (school_name) " +
                         " values " +
                         "('" + s_name + "')";


                    int result = (int)sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddArcher(string a_name, int aims_id, string a_sex, int s_id)
        {
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "insert into archers (school_id, archer_state_id, archer_name, archer_sex) values " +
                                         "(" + s_id + ", " + aims_id + ", '" + a_name + "', '" + a_sex + "'); SELECT CAST(scope_identity() AS int);";

                    int result = (int)sqlCmd.ExecuteScalar();

                    if (aims_id == 0 && result != 0)
                    {
                        using (SqlCommand sqlCmd1 = new SqlCommand())
                        {
                            sqlCmd1.Connection = dbConn;

                            sqlCmd1.CommandText =
                                    "Update archers set archer_state_id = " + result.ToString() + " where archer_id = " + result.ToString();

                            sqlCmd1.ExecuteNonQuery();
                        }

                    }
                }
            }
        }

        public ArcherData GetArcherData(int a_id)
        {
            ArcherData retData = null;

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = dbConn;

                    sqlCmd.CommandText = "select top 1 archer_data_id, archer_raw_data from archer_data where archer_id = " + a_id + " order by archer_data_id desc";

                    using (SqlDataReader theReader = sqlCmd.ExecuteReader())
                    {
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
                    }
                }
            }
            return retData;
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
