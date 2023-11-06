using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Software_Engineering_Project_New.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Engineering_Project_New
{
    internal class DBConnections
    {
        private static DBConnections _instance;

        private readonly string connectionString;

        private SqlConnection connectionToDatabase;

        private DBConnections()
        {
            connectionString = Settings.Default.CitisoftConnectionString;
        }

        public static DBConnections getInstanceOfDBConnection()
        {
            return _instance ?? (_instance = new DBConnections());
        }


        //accepts sql query and returns dataset of results from DB
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet ds = new DataSet();

            using (connectionToDatabase = new SqlConnection(connectionString))
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

        public bool doesUserExist(string username, string email)
        {
            object queryResult;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "SELECT COUNT(*) FROM Employees WHERE Username= @Username OR Email= @Email";
                command.Parameters.AddWithValue("Username", username);
                command.Parameters.AddWithValue("@Email", email);

                sqlcon.Open();
                queryResult = command.ExecuteScalar();
            }

            if (queryResult == null)
            {
                return false;
            }
            return true;
        }




        //
        public void addEmployeeToDB(string name, string contactNumber, string username, string password, string email,
            int roleID)
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

                sqlcmd.ExecuteNonQuery();
            }
        }

        public User getUserFromDB(string username, string password)
        {

            DataTable dt = new DataTable();

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "SELECT * FROM Employees WHERE Username = @Username";
                command.Parameters.AddWithValue("Username", username);

                SqlDataAdapter sda = new SqlDataAdapter(command);


                sda.Fill(dt);
            }


            if (dt.Rows.Count <= 0) return null; //if username not in db, return null

            string hashedPassword = dt.Rows[0]["Password"].ToString();

            if (BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword))
            {
                int id = Convert.ToInt32(dt.Rows[0]["EmployeeID"]);
                string name = dt.Rows[0]["Name"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                //string username = dt.Rows[0]["Name"].ToString();
                string contactNumber = dt.Rows[0]["Contact Number"].ToString();
                int? roleID = dt.Rows[0].Field<int?>("roleID");
                int? managerID = dt.Rows[0].Field<int?>("ManagerID");

                User user = new User(
                    id,
                    name,
                    email,
                    contactNumber,
                    username,
                    managerID,
                    roleID
                );
                MessageBox.Show("Hai");
                return user;
            }

            return null;
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