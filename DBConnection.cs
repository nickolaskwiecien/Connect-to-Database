using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace ProjectNorthwind1.Models
{
    public class DbConnection
    {
        //Private Lists of Models
        private List<Category> aListofCategories = new List<Category>();
        private List<Customers> aListofCustomers = new List<Customers>();
        private List<Employees> aListofEmployees = new List<Employees>();
        private List<OrderDetail> aListofOrderDetails = new List<OrderDetail>();
        private List<Orders> aListofOrders = new List<Orders>();
        private List<Products> aListofProducts = new List<Products>();
        private List<Shippers> aListofShippers = new List<Shippers>();
        private List<Supplier> aListofSuppliers = new List<Supplier>();

        private OleDbConnection aConnection = new OleDbConnection();

        //Listing Tables Method
        public List<Category> ListCategories()
        {
            string aSQL = "SELECT CategoryID, CategoryName, Description FROM Categories";


            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE";
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aCategoryID = (int)aReader["CategoryID"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                //this uses a constructor for the categoryid
                Category aCategory = new Category();

                //this uses sets and you msy not have set for categoryid
                aCategory.CategoryID = aCategoryID;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;

                aListofCategories.Add(aCategory);

            }

            aConnection.Close();

            return aListofCategories;

        }
        public List<Customers> ListCustomers()
        {
            string aSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, [Phone], [Fax] FROM Customers";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                string aCustomerID = (string)aReader["CustomerID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = Convert.ToString(aReader["Region"]);
                string aPostalCode = "N/A";
                if (aReader["PostalCode"] != System.DBNull.Value)
                    aPostalCode = Convert.ToString(aReader["PostalCode"]);
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "N/A";
                if (aReader["Fax"] != System.DBNull.Value)
                    aFax = Convert.ToString(aReader["Fax"]);

                //this uses a constructor for the categoryid
                Customers aCustomer = new Customers();

                aCustomer.CustomerID = aCustomerID;
                aCustomer.CompanyName = aCompanyName;
                aCustomer.ContactName = aContactName;
                aCustomer.ContactTitle = aContactTitle;
                aCustomer.Address = anAddress;
                aCustomer.City = aCity;
                aCustomer.Region = aRegion;
                aCustomer.PostalCode = aPostalCode;
                aCustomer.Country = aCountry;
                aCustomer.Phone = aPhone;
                aCustomer.Fax = aFax;

                aListofCustomers.Add(aCustomer);

            }

            aConnection.Close();

            return aListofCustomers;

        }
        public List<Employees> ListEmployees()
        {
            string aSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aEmployeeID = (int)aReader["EmployeeID"];
                string aLastName = (string)aReader["LastName"];
                string aFirstName = (string)aReader["FirstName"];
                string aTitle = (string)aReader["Title"];
                string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                DateTime aBirthDate = (DateTime)aReader["BirthDate"];
                DateTime aHireDate = (DateTime)aReader["HireDate"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = Convert.ToString(aReader["Region"]);
                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aHomePhone = (string)aReader["HomePhone"];
                string aExtension = (string)aReader["Extension"];
                string aPhoto = (string)aReader["Photo"];
                string aNotes = (string)aReader["Notes"];
                int aReportsTo = 0;
                if (aReader["ReportsTo"] != System.DBNull.Value)
                    aReportsTo = Convert.ToInt32(aReader["ReportsTo"]);

                //this uses a constructor for the categoryid
                Employees anEmployee = new Employees();

                anEmployee.EmployeeID = aEmployeeID;
                anEmployee.LastName = aLastName;
                anEmployee.FirstName = aFirstName;
                anEmployee.Title = aTitle;
                anEmployee.TitleofCourtesy = aTitleOfCourtesy;
                anEmployee.BirthDate = aBirthDate;
                anEmployee.HireDate = aHireDate;
                anEmployee.Address = anAddress;
                anEmployee.City = aCity;
                anEmployee.Region = aRegion;
                anEmployee.PostalCode = aPostalCode;
                anEmployee.Country = aCountry;
                anEmployee.HomePhone = aHomePhone;
                anEmployee.Extension = aExtension;
                anEmployee.Photo = aPhoto;
                anEmployee.Notes = aNotes;
                anEmployee.ReportsTo = aReportsTo;

                aListofEmployees.Add(anEmployee);

            }

            aConnection.Close();

            return aListofEmployees;

        }
        public List<OrderDetail> ListOrderDetails()
        {
            string aSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aOrderID = (int)aReader["OrderID"];
                int aProductID = (int)aReader["ProductID"];
                int aUnitPrice = Convert.ToInt32(aReader["UnitPrice"]);
                int aQuantity = Convert.ToInt32(aReader["Quantity"]);
                decimal aDiscount = Convert.ToDecimal(aReader["Discount"]);

                //this uses a constructor for the categoryid
                OrderDetail anOrderDetail = new OrderDetail();

                anOrderDetail.OrderID = aOrderID;
                anOrderDetail.ProductID = aProductID;
                anOrderDetail.UnitPrice = aUnitPrice;
                anOrderDetail.Quantity = aQuantity;
                anOrderDetail.Discount = aDiscount;

                aListofOrderDetails.Add(anOrderDetail);

            }

            aConnection.Close();

            return aListofOrderDetails;

        }
        public List<Orders> ListOrders()
        {
            string aSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int anOrderID = (int)aReader["OrderID"];
                string aCustomerID = (string)aReader["CustomerID"];
                int anEmployeeID = (int)aReader["EmployeeID"];
                DateTime anOrderDate = Convert.ToDateTime(aReader["OrderDate"]);
                DateTime aRequiredDate = Convert.ToDateTime(aReader["RequiredDate"]);
                DateTime aShippedDate = default(DateTime);
                if (aReader["ShippedDate"] != System.DBNull.Value)
                    aShippedDate = Convert.ToDateTime(aReader["ShippedDate"]);
                int aShipVia = 0;
                if (aReader["ShipVia"] != System.DBNull.Value)
                    aShipVia = Convert.ToInt32(aReader["ShipVia"]);
                int aFreight = Convert.ToInt32(aReader["Freight"]);
                string aShipName = (string)aReader["ShipName"];
                string aShipAddress = (string)aReader["ShipAddress"];
                string aShipCity = (string)aReader["ShipCity"];
                string aShipRegion = "";
                if (aReader["ShipRegion"] != System.DBNull.Value)
                    aShipRegion = (string)aReader["ShipRegion"];
                string aShipPostalCode = "";
                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                    aShipPostalCode = (string)aReader["ShipPostalCode"];
                string aShipCountry = (string)aReader["ShipCountry"];

                //this uses a constructor for the categoryid
                Orders anOrder = new Orders();

                anOrder.OrderID = anOrderID;
                anOrder.CustomerID = aCustomerID;
                anOrder.EmployeeID = anEmployeeID;
                anOrder.OrderDate = anOrderDate;
                anOrder.RequiredDate = aRequiredDate;
                anOrder.ShippedDate = aShippedDate;
                anOrder.ShipVia = aShipVia;
                anOrder.Freight = aFreight;
                anOrder.ShipName = aShipName;
                anOrder.ShipAddress = aShipAddress;
                anOrder.ShipCity = aShipCity;
                anOrder.ShipRegion = aShipRegion;
                anOrder.ShipPostalCode = aShipPostalCode;
                anOrder.ShipCountry = aShipCountry;

                aListofOrders.Add(anOrder);

            }

            aConnection.Close();

            return aListofOrders;

        }
        public List<Products> ListProducts()

        {
            string aSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aProductID = (int)aReader["ProductID"];
                string aProductName = (string)aReader["ProductName"];
                int aSupplierID = Convert.ToInt32(aReader["SupplierID"]);
                int aCategoryID = Convert.ToInt32(aReader["CategoryID"]);
                string aQuantityPerUnit = Convert.ToString(aReader["QuantityPerUnit"]);
                int aUnitPrice = Convert.ToInt32(aReader["UnitPrice"]);
                int aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
                int aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
                int aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
                bool aDiscontinued = (bool)aReader["Discontinued"];

                //this uses a constructor for the categoryid
                Products aProduct = new Products();

                aProduct.ProductID = aProductID;
                aProduct.ProductName = aProductName;
                aProduct.SupplierID = aSupplierID;
                aProduct.CategoryID = aCategoryID;
                aProduct.QuanperUnit = aQuantityPerUnit;
                aProduct.UnitPrice = aUnitPrice;
                aProduct.UnitsInStock = aUnitsInStock;
                aProduct.UnitsonOrder = aUnitsOnOrder;
                aProduct.ReorderLevel = aReorderLevel;
                aProduct.Discontinued = aDiscontinued;

                aListofProducts.Add(aProduct);

            }

            aConnection.Close();

            return aListofProducts;

        }
        public List<Shippers> ListShippers()
        {
            string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aShipperID = (int)aReader["ShipperID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aPhone = (string)aReader["Phone"];
                
                //this uses a constructor for the categoryid
                Shippers aShipper = new Shippers();

                aShipper.ShipperID = aShipperID;
                aShipper.CompanyName = aCompanyName;
                aShipper.Phone = aPhone;
                

                aListofShippers.Add(aShipper);

            }

            aConnection.Close();

            return aListofShippers;

        }
        public List<Supplier> ListSuppliers()
        {
            string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aSupplierID = (int)aReader["SupplierID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = (string)aReader["Region"];
                string aPostalCode = "";
                if (aReader["PostalCode"] != System.DBNull.Value)
                    aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "";
                if (aReader["Fax"] != System.DBNull.Value)
                    aFax = (string)aReader["Fax"];
                string aHomePage = "";
                if (aReader["HomePage"] != System.DBNull.Value)
                    aHomePage = (string)aReader["HomePage"];

                //this uses a constructor for the categoryid
                Supplier aSupplier = new Supplier();

                aSupplier.SupplierID = aSupplierID;
                aSupplier.CompanyName = aCompanyName;
                aSupplier.ContactName = aContactName;
                aSupplier.ContactTitle = aContactTitle;
                aSupplier.Address = anAddress;
                aSupplier.City = aCity;
                aSupplier.Region = aRegion;
                aSupplier.PostalCode = aPostalCode;
                aSupplier.Country = aCountry;
                aSupplier.Phone = aPhone;
                aSupplier.Fax = aFax;
                aSupplier.HomePage = aHomePage;

                aListofSuppliers.Add(aSupplier);

            }

            aConnection.Close();

            return aListofSuppliers;

        }

        ////To Select Appropriate Corresponding Table in Relation to Other Tables
        public Category GetaCategory(int id)
        {
            Category aCategory = new Category();

            string aSQL = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID = " + id;
            
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();
            
            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aCategoryID = (int)aReader["CategoryID"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];


                //this uses sets and you may not have set for categoryid
                aCategory.CategoryID = aCategoryID;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;
            }

            aConnection.Close();

            return aCategory;

        }
        public Customers GetaCustomer(string id)
        {
            Customers aCustomer = new Customers();

            string aSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, [Phone], [Fax] FROM Customers WHERE CustomerID = '" + id + "'";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                string aCustomerID = (string)aReader["CustomerID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = Convert.ToString(aReader["Region"]);
                string aPostalCode = "N/A";
                if (aReader["PostalCode"] != System.DBNull.Value)
                    aPostalCode = Convert.ToString(aReader["PostalCode"]);
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "N/A";
                if (aReader["Fax"] != System.DBNull.Value)
                    aFax = Convert.ToString(aReader["Fax"]);
                

                aCustomer.CustomerID = aCustomerID;
                aCustomer.CompanyName = aCompanyName;
                aCustomer.ContactName = aContactName;
                aCustomer.ContactTitle = aContactTitle;
                aCustomer.Address = anAddress;
                aCustomer.City = aCity;
                aCustomer.Region = aRegion;
                aCustomer.PostalCode = aPostalCode;
                aCustomer.Country = aCountry;
                aCustomer.Phone = aPhone;
                aCustomer.Fax = aFax;
            }

            aConnection.Close();

            return aCustomer;

        }
        public Employees GetanEmployee(int id)
        {
            Employees anEmployee = new Employees();

            string aSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees WHERE EmployeeID = " + id;

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aEmployeeID = (int)aReader["EmployeeID"];
                string aLastName = (string)aReader["LastName"];
                string aFirstName = (string)aReader["FirstName"];
                string aTitle = (string)aReader["Title"];
                string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                DateTime aBirthDate = (DateTime)aReader["BirthDate"];
                DateTime aHireDate = (DateTime)aReader["HireDate"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = Convert.ToString(aReader["Region"]);
                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aHomePhone = (string)aReader["HomePhone"];
                string aExtension = (string)aReader["Extension"];
                string aPhoto = (string)aReader["Photo"];
                string aNotes = (string)aReader["Notes"];
                int aReportsTo = 0;
                if (aReader["ReportsTo"] != System.DBNull.Value)
                    aReportsTo = Convert.ToInt32(aReader["ReportsTo"]);

                anEmployee.EmployeeID = aEmployeeID;
                anEmployee.LastName = aLastName;
                anEmployee.FirstName = aFirstName;
                anEmployee.Title = aTitle;
                anEmployee.TitleofCourtesy = aTitleOfCourtesy;
                anEmployee.BirthDate = aBirthDate;
                anEmployee.HireDate = aHireDate;
                anEmployee.Address = anAddress;
                anEmployee.City = aCity;
                anEmployee.Region = aRegion;
                anEmployee.PostalCode = aPostalCode;
                anEmployee.Country = aCountry;
                anEmployee.HomePhone = aHomePhone;
                anEmployee.Extension = aExtension;
                anEmployee.Photo = aPhoto;
                anEmployee.Notes = aNotes;
                anEmployee.ReportsTo = aReportsTo;
            }

            aConnection.Close();

            return anEmployee;

        }
        public Orders GetanOrder(int id)
        {
            Orders anOrder = new Orders();

            string aSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE OrderID = " + id;

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int anOrderID = (int)aReader["OrderID"];
                string aCustomerID = (string)aReader["CustomerID"];
                int anEmployeeID = (int)aReader["EmployeeID"];
                DateTime anOrderDate = Convert.ToDateTime(aReader["OrderDate"]);
                DateTime aRequiredDate = Convert.ToDateTime(aReader["RequiredDate"]);
                DateTime aShippedDate = default(DateTime);
                if (aReader["ShippedDate"] != System.DBNull.Value)
                    aShippedDate = Convert.ToDateTime(aReader["ShippedDate"]);
                int aShipVia = 0;
                if (aReader["ShipVia"] != System.DBNull.Value)
                    aShipVia = Convert.ToInt32(aReader["ShipVia"]);
                int aFreight = Convert.ToInt32(aReader["Freight"]);
                string aShipName = (string)aReader["ShipName"];
                string aShipAddress = (string)aReader["ShipAddress"];
                string aShipCity = (string)aReader["ShipCity"];
                string aShipRegion = "";
                if (aReader["ShipRegion"] != System.DBNull.Value)
                    aShipRegion = (string)aReader["ShipRegion"];
                string aShipPostalCode = "";
                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                    aShipPostalCode = (string)aReader["ShipPostalCode"];
                string aShipCountry = (string)aReader["ShipCountry"];

                anOrder.OrderID = anOrderID;
                anOrder.CustomerID = aCustomerID;
                anOrder.EmployeeID = anEmployeeID;
                anOrder.OrderDate = anOrderDate;
                anOrder.RequiredDate = aRequiredDate;
                anOrder.ShippedDate = aShippedDate;
                anOrder.ShipVia = aShipVia;
                anOrder.Freight = aFreight;
                anOrder.ShipName = aShipName;
                anOrder.ShipAddress = aShipAddress;
                anOrder.ShipCity = aShipCity;
                anOrder.ShipRegion = aShipRegion;
                anOrder.ShipPostalCode = aShipPostalCode;
                anOrder.ShipCountry = aShipCountry;
            }

            aConnection.Close();

            return anOrder;

        }
        public Products GetaProduct(int id)
        {
            Products aProduct = new Products();

            string aSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE ProductID = " + id;

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aProductID = (int)aReader["ProductID"];
                string aProductName = (string)aReader["ProductName"];
                int aSupplierID = Convert.ToInt32(aReader["SupplierID"]);
                int aCategoryID = Convert.ToInt32(aReader["CategoryID"]);
                string aQuantityPerUnit = Convert.ToString(aReader["QuantityPerUnit"]);
                int aUnitPrice = Convert.ToInt32(aReader["UnitPrice"]);
                int aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
                int aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
                int aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
                bool aDiscontinued = (bool)aReader["Discontinued"];

                aProduct.ProductID = aProductID;
                aProduct.ProductName = aProductName;
                aProduct.SupplierID = aSupplierID;
                aProduct.CategoryID = aCategoryID;
                aProduct.QuanperUnit = aQuantityPerUnit;
                aProduct.UnitPrice = aUnitPrice;
                aProduct.UnitsInStock = aUnitsInStock;
                aProduct.UnitsonOrder = aUnitsOnOrder;
                aProduct.ReorderLevel = aReorderLevel;
                aProduct.Discontinued = aDiscontinued;

            }

            aConnection.Close();

            return aProduct;

        }
        public Shippers GetaShipper(int id)
        {
            Shippers aShipper = new Shippers();

            string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers WHERE ShipperID = " + id;

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aShipperID = (int)aReader["ShipperID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aPhone = (string)aReader["Phone"];


                //this uses sets and you may not have set for categoryid
                aShipper.ShipperID = aShipperID;
                aShipper.CompanyName = aCompanyName;
                aShipper.Phone = aPhone;

            }

            aConnection.Close();

            return aShipper;

        }
        public Supplier GetaSupplier(int id)
        {
            Supplier aSupplier = new Supplier();

            string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE SupplierID = " + id;

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:INSERT PATH TO NORTHWIND FILE;
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();


            while (aReader.Read())
            {
                int aSupplierID = (int)aReader["SupplierID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string anAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "";
                if (aReader["Region"] != System.DBNull.Value)
                    aRegion = (string)aReader["Region"];
                string aPostalCode = "";
                if (aReader["PostalCode"] != System.DBNull.Value)
                    aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "";
                if (aReader["Fax"] != System.DBNull.Value)
                    aFax = (string)aReader["Fax"];
                string aHomePage = "";
                if (aReader["HomePage"] != System.DBNull.Value)
                    aHomePage = (string)aReader["HomePage"];

                aSupplier.SupplierID = aSupplierID;
                aSupplier.CompanyName = aCompanyName;
                aSupplier.ContactName = aContactName;
                aSupplier.ContactTitle = aContactTitle;
                aSupplier.Address = anAddress;
                aSupplier.City = aCity;
                aSupplier.Region = aRegion;
                aSupplier.PostalCode = aPostalCode;
                aSupplier.Country = aCountry;
                aSupplier.Phone = aPhone;
                aSupplier.Fax = aFax;
                aSupplier.HomePage = aHomePage;
            }

            aConnection.Close();

            return aSupplier;
        }


    }
}
