using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //
        public void addEmployeeToDB(string name, string contactNumber, string username, string password, string email, int roleID)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("EmployeesAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Name", name);
                sqlcmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                sqlcmd.Parameters.AddWithValue("@Username", username);
                sqlcmd.Parameters.AddWithValue("@Password", password);
                sqlcmd.Parameters.AddWithValue("@Email", email);
                sqlcmd.Parameters.AddWithValue("@RoleID", roleID);


                //  sqlcmd.Parameters.AddWithValue("@RoleID", txt_roleid);
                sqlcmd.ExecuteNonQuery();


            }
        }

        public User veryfyLogin(string username, string password)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            String querry = "SELECT * FROM Employees WHERE Username = '" + username + "' AND Password = '" + password + "'";

            DataSet ds = getDataSet(querry);

            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            


            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(dt.Columns[0].ToString());

                string name = dt.Rows[0]["Name"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                //string username = dt.Rows[0]["Name"].ToString();
                string contactNumber = dt.Rows[0]["Contact Number"].ToString();
                int? roleID = Convert.ToInt32(dt.Rows[0]["RoleID"]);
                int? managerID = Convert.ToInt32(dt.Rows[0]["ManagerID"]);

                User user = new User(
                    name,
                    email,
                    username,
                    contactNumber,
                    roleID,
                    managerID
                    );
                return user;


            }
            else
            {
                return null;
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
