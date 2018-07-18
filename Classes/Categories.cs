using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Category
    {

        //Private Variables
        private int categoryid;
        private string categoryname;
        private string description;

        //Gets & Sets
        public int CategoryID
        {
            get
            {
                return this.categoryid;
            }
            set
            {
                this.categoryid = value;
            }
        }
        public string CategoryName
        {
            get
            {
                return this.categoryname;
            }
            set
            {
                this.categoryname = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        //Constructors
        public Category()
        {

        }
        public Category(int id, string catname, string desc):this()
        {

        }
        public Category(string catname, string desc)
        {
            this.categoryid = -1;
            this.CategoryName = catname;
            this.Description = desc;
        }
        public Category(int id, string catname):this(id, catname, "N/A")
        {
        }
        public Category(int id):this(id, "N/A", "N/A")
        {

        }

        //ToString
        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Category ID: " + this.CategoryID + "\n";
            aMessage += aMessage + "Category Name: " + this.CategoryName + "\n";
            aMessage += aMessage + "Description: " + this.Description + "\n";

            return aMessage;
        }
    }
}
