using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Supplier
    {
        private int supplierID;
        private string companyname;
        private string contactname;
        private string contacttitle;
        private string address;
        private string city;
        private string region;
        private string postalcode;
        private string country;
        private string phone;
        private string fax;
        private string homepage;


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
        public string CompanyName
        {
            get
            {
                return this.companyname;
            }
            set
            {
                this.companyname = value;
            }
        }
        public string ContactName
        {
            get
            {
                return this.contactname;
            }
            set
            {
                this.contactname = value;
            }
        }
        public string ContactTitle
        {
            get
            {
                return this.contacttitle;
            }
            set
            {
                this.contacttitle = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                this.region = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalcode;
            }
            set
            {
                this.postalcode = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }
        public string HomePage
        {
            get
            {
                return this.homepage;
            }
            set
            {
                this.homepage = value;
            }
        }


        public Supplier()
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string phone, string fax, string index):this()
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string phone, string fax) : this(id, comname, contname, addy, city, reg, post, phone, fax, "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string phone) : this(id, comname, contname, addy, city, reg, post, phone, "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post) : this(id, comname, contname, addy, city, reg, post, "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg) : this(id, comname, contname, addy, city, reg, "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city) : this(id, comname, contname, addy, city, "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy) : this(id, comname, contname, addy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname) : this(id, comname, contname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname) : this(id, comname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id) : this(id, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Supplier ID  : " + SupplierID + "\n";
            aMessage += aMessage + "Comapny Name : " + CompanyName + "\n";
            aMessage += aMessage + "Contact Name : " + ContactName + "\n";
            aMessage += aMessage + "Contact Title: " + ContactTitle + "\n";
            aMessage += aMessage + "Address      : " + Address + "\n";
            aMessage += aMessage + "City         : " + City + "\n";
            aMessage += aMessage + "Region       : " + Region + "\n";
            aMessage += aMessage + "Postal Code  : " + PostalCode + "\n";
            aMessage += aMessage + "Phone        : " + Phone + "\n";
            aMessage += aMessage + "Fax          : " + Fax + "\n";
            aMessage += aMessage + "Home Page    : " + HomePage + "\n";

            return aMessage;
        }
    }
}
