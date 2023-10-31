using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project_New
{
    internal class DBConnections
    {
        private static DBConnections _instance;

        private string connectionString;

        private SqlConnection connectionToDatabase;

        private DBConnections()
        {

            connectionString = Properties.Settings.Default.CitisoftDBConnection;

        }

        public static DBConnections getInstanceOfDBConnection()
        {

            if (_instance == null)
            {
                _instance = new DBConnections();
            }
            return _instance;

        }

        
        //accepts sql query and returns dataset of results from DB
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet ds = new DataSet();

            using(connectionToDatabase = new SqlConnection(connectionString))
            {
                //open connection to db
                connectionToDatabase.Open();


                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connectionToDatabase);

                //fills dataset with contents of db
                da.Fill(ds);

                ///close connection to db
                connectionToDatabase.Close();

            }

            return ds;
        }

        public void saveToDB(string sqlQuery, string name, int age)
        {
            using (SqlConnection connToDB = new SqlConnection(connectionString))
            {
                //open connection
                connectionToDatabase.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionToDatabase);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("Age", age));

                //execute the command
                sqlCommand.ExecuteNonQuery();

                connectionToDatabase.Close();
            }

        }



    }
}

/*
Resources Used:  
Help With Setting Up The DB - https://canvas.anglia.ac.uk/courses/33889/files/4029182?module_item_id=1877766 

Help With Syntax For SQL Statements - https://canvas.anglia.ac.uk/courses/33889/files/4029173?module_item_id=1877768

Help With Using Datasets - https://learn.microsoft.com/en-us/dotnet/api/system.data.dataset
  
Help With Generating SQL Commands - https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient

Help With SqLDataAdapter - https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter

 */
