using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net.Configuration;
using System.Windows.Forms;
using Software_Engineering_Project_New.Properties;

namespace Software_Engineering_Project_New
{
    internal class DBConnections
    {
        private static DBConnections _instance;

        private readonly string connectionString;

        private SqlConnection connectionToDatabase;

        private DBConnections()
        {
            //connectionString = Settings.Default.CitisoftConnectionString;
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

                //close connection to db
                connectionToDatabase.Close();
            }

            return ds;
        }

        public DataTable getDataTable(string sqlQuery)
        {
            return getDataSet(sqlQuery).Tables[0];
        }


        //returns true if a user with that username or email exists within the database
        public bool doesUserExist(string username, string email)
        {
            int count;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = Constants.COUNT_PEOPLE_WITH_NAME_AND_EMAIL;
                command.Parameters.AddWithValue("Username", username);
                command.Parameters.AddWithValue("@Email", email);

                sqlcon.Open();
                count = (int)command.ExecuteScalar();
            }

            return count >= 1;
        }

        public int getUserID(String user)
        {
            string usernameToSearch = user;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                

                // Construct the SQL query with a parameterized query to avoid SQL injection
                string sqlQuery = "SELECT EmployeeID FROM Employees WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Username", usernameToSearch);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        Console.WriteLine($"UserID for {usernameToSearch}: {userId}");

                        return userId;

                        
                    }
                    else
                    {
                        Console.WriteLine($"No user found with username: {usernameToSearch}");
                        return 0;
                    }
                }
            }
        }

        public void accountRecovery(int employeeId, String NewPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Employees SET Password = @NewPassword WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(updateQuery,connection))
                {

                    
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New password has been set");
                    }
                    else
                    {
                        MessageBox.Show($"No user found with UserID: " + employeeId);
                    }
                }
            }
        }

        public void updateRoleID(int EmployeeID, int newRole)
        {
            int EmployeesIdToUpdate = EmployeeID; // Replace with the actual UserID you want to update
            int newRoleId = newRole; // Replace with the new RoleID value

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Construct the SQL update query
                string updateQuery = "UPDATE Employees SET RoleID = @NewRoleID WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@NewRoleID", newRoleId);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeesIdToUpdate);

                    // Execute the update query
                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"RoleID updated successfully for UserID {EmployeesIdToUpdate}");
                    }
                    else
                    {
                        Console.WriteLine($"No user found with UserID {EmployeesIdToUpdate}");
                    }
                }
            }
        }


        // int adj is for the value it will be updated too
        public void roleIdChange(int roleID, String Email, String Username)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
               

                bool exists = doesUserExist(Username, Email);

                if (exists)
                {
                    int EmployeeID;
                    EmployeeID = getUserID(Username);

                    MessageBox.Show(EmployeeID.ToString());
                    updateRoleID(EmployeeID, roleID);
                    
                }
                else
                {
                    MessageBox.Show("Inavlid username and email");


                }
            }
        }

        public DataTable Search(string search, bool filterCloudServices = false)
        {
            DataTable searchResults = new DataTable();

            using (SqlConnection connectionToDatabase = new SqlConnection(connectionString))
            {
                connectionToDatabase.Open();

                string query = "SELECT * FROM Softwares WHERE Name LIKE @search";
                
                // Use CASE WHEN to conditionally filter by Cloud Services Available
                if (filterCloudServices == true){
                    
                    query += " AND [Cloud Services Avaliable] = @filterCloudServices";
                }
                using (SqlCommand command = new SqlCommand(query, connectionToDatabase))
                {
                    if (filterCloudServices == true)
                    {

                        command.Parameters.Add(new SqlParameter("@filterCloudServices", filterCloudServices));
                    }

                    command.Parameters.Add(new SqlParameter("@search", "%" + search + "%"));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        searchResults.Load(reader);
                    }
                }
            }

            return searchResults;
        }

        public void updateSoftware(int softwareID, string pdfFilePath)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                //command.CommandText = "SELECT COUNT(*) FROM Employees WHERE Username= @Username OR Email= @Email";
                command.CommandText =
                    "UPDATE Softwares SET [Document Link] = @pdfFilePath WHERE SoftwareID = @SoftwareID";
                command.Parameters.AddWithValue("@SoftwareID", softwareID);
                command.Parameters.AddWithValue("@pdfFilePath", pdfFilePath);

                sqlcon.Open();

                command.ExecuteNonQuery();
            }
        }

        public void deleteEmployee(int employeeID)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                //command.CommandText = "SELECT COUNT(*) FROM Employees WHERE Username= @Username OR Email= @Email";
                command.CommandText = Constants.DELETE_EMPLOYEE;
                command.Parameters.AddWithValue("@EmployeeID", employeeID);

                sqlcon.Open();

                command.ExecuteNonQuery();
            }
        }
        
        //
        public void addEmployeeToDB(string name, string contactNumber, string username, string password, string email,
            int? roleID)
        {
            //return _instance ?? (_instance = new DBConnections());

            //param.Value = activity.StaffId ?? (object)DBNull.Value;

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
                sqlcmd.Parameters.AddWithValue("@RoleID", (roleID ?? (object)DBNull.Value)); //if roleID is null, set the parameter to null aswell
                

                sqlcmd.ExecuteNonQuery();
                
            }
           
        }
        
        public void UpdateEmployeeInDB(int employeeID, string name, string contactNumber, string username, string password, string email)
        {
             using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    
                    string query = "UPDATE Employees " +
                                   "SET Name = @Name, " +
                                   "    [Contact Number] = @ContactNumber, " +
                                   "    Username = @Username, " +
                                   "    Password = @Password, " +
                                   "    Email = @Email " +
                                   "WHERE EmployeeID = @EmployeeID";
            
                    using (SqlCommand sqlcmd = new SqlCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        sqlcmd.Parameters.AddWithValue("@Name", name);
                        sqlcmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        sqlcmd.Parameters.AddWithValue("@Username", username);
                        sqlcmd.Parameters.AddWithValue("@Password", password);
                        sqlcmd.Parameters.AddWithValue("@Email", email);
            
                        sqlcmd.ExecuteNonQuery();
                    }
                }
        }
        public void InsertReviewIntoDatabase(int softwareId, string reviewText, int userId)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                string query = "INSERT INTO Reviews (SoftwareID,EmployeeID, [Review Text],[Date of Review], [Review Score]) " +
                               "VALUES (@SoftwareID,@EmployeeID, @ReviewText,@DateOfReview, @score )";

                using (SqlCommand sqlcmd = new SqlCommand(query, sqlcon))
                {
                    sqlcmd.Parameters.AddWithValue("@SoftwareID", softwareId);
                    sqlcmd.Parameters.AddWithValue("@ReviewText", reviewText);
                    sqlcmd.Parameters.AddWithValue("@EmployeeID", userId);
                    // Add the current date to the parameter
                    sqlcmd.Parameters.AddWithValue("@DateOfReview", DateTime.Now);
                    //sets score to zero for now
                    sqlcmd.Parameters.AddWithValue("@score", 0);

                    
                    sqlcmd.ExecuteNonQuery();
                }
            }
        }

        //returns a user class if employee exists, else returns null
        public User getUserFromDB(string username, string password)
        {
            DataTable dt = new DataTable();

            //searching DB for user with provided username and populates a datatable with the results
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                //command.CommandText = "SELECT * FROM Employees WHERE Username = @Username";
                command.CommandText = Constants.SELECT_EMPLOYEE_WITH_USERNAME;
                command.Parameters.AddWithValue("Username", username);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(dt);
            }


            if (dt.Rows.Count <= 0) return null; //if username not in db, return null


            string hashedPassword = dt.Rows[0]["Password"].ToString();
            if (BCrypt.Net.BCrypt.EnhancedVerify(password,
                    hashedPassword)) //checks entered password is same as stored password
            {
                //gets data from the datatable
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
                return user;
            }


            return null;
        }
        
        public bool VerifyCurrentPassword(string username, string currentPassword)
        {
            DataTable dt = new DataTable();

            // Search the DB for the user with the provided username and populate a datatable with the results
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = Constants.SELECT_EMPLOYEE_WITH_USERNAME;
                command.Parameters.AddWithValue("Username", username);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(dt);
            }

           
           // if (dt.Rows.Count <= 0) return false; // If username not in db, return false

            string hashedPassword = dt.Rows[0]["Password"].ToString();

            // Verify the entered password
            return BCrypt.Net.BCrypt.EnhancedVerify(currentPassword, hashedPassword);
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