using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Products
    {
        //Private Variables
        private int productID;
        private string productname;
        private int supplierID;
        private int categoryID;
        private string quanperunit;
        private int unitprice;
        private int unitsinstock;
        private int unitsonorder;
        private int reorderlevel;
        private bool discontinued;

        //Gets & Sets
        public int ProductID
        {
            get
            {
                return this.productID;
            }
            set
            {
                this.productID = value;
            }
        }
        public string ProductName
        {
            get
            {
                return this.productname;
            }
            set
            {
                this.productname = value;
            }
        }
        public int SupplierID
        {
            get
            {
                return this.supplierID;
            }
            set
            {
                this.supplierID = value;
            }
        }
        public int CategoryID
        {
            get
            {
                return this.categoryID;
            }
            set
            {
                this.categoryID = value;
            }
        }
        public string QuanperUnit
        {
            get
            {
                return this.quanperunit;
            }
            set
            {
                this.quanperunit = value;
            }
        }
        public int UnitPrice
        {
            get
            {
                return this.unitprice;
            }
            set
            {
                this.unitprice = value;
            }
        }
        public int UnitsInStock
        {
            get
            {
                return this.unitsinstock;
            }
            set
            {
                this.unitsinstock = value;
            }
        }
        public int UnitsonOrder
        {
            get
            {
                return this.unitsonorder;
            }
            set
            {
                this.unitsonorder = value;
            }
        }
        public int ReorderLevel
        {
            get
            {
                return this.reorderlevel;
            }
            set
            {
                this.reorderlevel = value;
            }
        }
        public bool Discontinued
        {
            get
            {
                return this.discontinued;
            }
            set
            {
                this.discontinued = value;
            }
        }

        //Constructors
        public Products()
        {

        }
        public Products(int pID, string name, int sID, int cID, string quan, int price, int stock, int order, int reorder, bool dis):this()
        {

        }
        public Products(int pID, string name, int sID, int cID, string quan, int price, int stock, int order, int reorder) : this(pID, name, sID, cID, quan, price, stock, order, reorder, false)
        {

        }
        public Products(int pID, string name, int sID, int cID, string quan, int price, int stock, int order) : this(pID, name, sID, cID, quan, price, stock, order, -1, false)
        {

        }
        public Products(int pID, string name, int sID, int cID, string quan, int price, int stock) : this(pID, name, sID, cID, quan, price, stock, -1, -1, false)
        {

        }
        public Products(int pID, string name, int sID, int cID, string quan) : this(pID, name, sID, cID, quan, -1, -1, -1, -1, false)
        {

        }
        public Products(int pID, string name, int sID, int cID) : this(pID, name, sID, cID, "N/A", -1, -1, -1, -1, false)
        {

        }
        public Products(int pID, string name, int sID) : this(pID, name, sID, -1, "N/A", -1, -1, -1, -1, false)
        {

        }
        public Products(int pID, string name) : this(pID, name, -1, -1, "N/A", -1, -1, -1, -1, false)
        {

        }
        public Products(int pID) : this(pID, "N/A", -1, -1, "N/A", -1, -1, -1, -1, false)
        {

        }

        //To String
        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Product ID:        " + ProductID + "\n";
            aMessage += aMessage + "Product Name:      " + ProductName + "\n";
            aMessage += aMessage + "Supplier ID:       " + SupplierID + "\n";
            aMessage += aMessage + "Category ID:       " + CategoryID + "\n";
            aMessage += aMessage + "Quantity Per Unit: " + QuanperUnit + "\n";
            aMessage += aMessage + "Unit Price:        " + UnitPrice + "\n";
            aMessage += aMessage + "Units in Stock:    " + UnitsInStock + "\n";
            aMessage += aMessage + "Units on Order:    " + UnitsonOrder + "\n";
            aMessage += aMessage + "Reorder Level:     " + ReorderLevel + "\n";
            aMessage += aMessage + "Discontinued:      " + Discontinued + "\n";

            return aMessage;
        }

    }
}
