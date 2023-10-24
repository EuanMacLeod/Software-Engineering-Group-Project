﻿using System;
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
        //"SELECT * FROM Vendors INNER JOIN Branches ON Vendors.VendorID = Branches.VendorID";
        public static string SELECTALLBRANCHES = "SELECT v.Name AS Vendor, v.Website, v.Email, b.Country, b.City FROM Vendors v INNER JOIN Branches b ON v.VendorID = b.VendorID";

        public static string SELECTALLSOFTWARES = "SELECT * FROM Softwares";

        public static string SELECTALLPURCHASEDSOFTWARES = "SELECT s.SoftwareID, s.Name AS Software, c.ClientID, c.Name AS ClientName FROM Softwares s INNER JOIN PurchasedSoftwares ON s.SoftwareID = PurchasedSoftwares.SoftwareID INNER JOIN Clients c ON PurchasedSoftwares.ClientID = c.ClientID";

        public static string SELECTALLSOFTWAREMODULES = "SELECT s.SoftwareID, s.Name AS Software, m.SoftwareModuleID, m.Module FROM Softwares s INNER JOIN SoftwareModules m ON s.SoftwareID = m.SoftwareID";

        public static string SELECTALLSOFTWARECLIENTTYPES = "SELECT s.SoftwareID, s.Name AS Software, c.FinancialServicesClientType AS ClientType FROM Softwares s INNER JOIN SoftwareClientTypes ON s.SoftwareID = SoftwareClientTypes.SoftwareID INNER JOIN FinancialServicesClientTypes c ON SoftwareClientTypes.FinancialServicesClientTypeID = c.FinancialServicesClientTypeID";

        public static string SELECTALLTYPESOFSOFTWARES = "SELECT s.SoftwareID, s.Name AS Software, t.SoftwareType AS TypeOfSoftware FROM Softwares s INNER JOIN SoftwareTypes ON s.SoftwareID = SoftwareTypes.SoftwareID INNER JOIN TypeOfSoftware t ON SoftwareTypes.TypeID = t.TypeID";

        public static string SELECTALLSOFTWAREBUISNESSAREAS = "SELECT s.SoftwareID, s.Name AS Software, b.BusinessArea FROM Softwares s INNER JOIN SoftwareBusinessAreas ON s.SoftwareID = SoftwareBusinessAreas.SoftwareID INNER JOIN BusinessAreas b ON SoftwareBusinessAreas.BusinessAreaID = b.BusinessAreaID";

        //public static string INSERTPerson = "INSERT INTO Person (Name, Age) VALUES (@Name, @Age)";
        //Constants.INSERTPerson, name, age);


    }
}