using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project_New
{
    internal class Constants
    {
        //sql queries

        //
        public static string SELECTALLEMPLOYEES  = "SELECT * FROM Employees";

        //
        public static string SELECTALLVENDORS = "SELECT * FROM Vendors";

        //
        public static string SELECTALLMANAGERS = " SELECT e.EmployeeID, e.name, e.ManagerID, m.name AS ManagerName FROM Employees e INNER JOIN employees m ON e.ManagerID = m.EmployeeID";

        // "SELECT * FROM Branches INNER JOIN Vendors ON Branches.VendorID = Vendors.VendorID";
        public static string SELECTALLBRANCHES = "SELECT * FROM Vendors INNER JOIN Branches ON Vendors.VendorID = Branches.VendorID";


    }
}