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
