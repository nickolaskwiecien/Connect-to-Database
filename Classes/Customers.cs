using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Customers
    {
        private string customerid;
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

        public string CustomerID
        {
            get
            {
                return this.customerid;
            }
            set
            {
                this.customerid = value;
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
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
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

        public Customers()
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city, string reg, string post, string country, string phone, string fax):this()
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city, string reg, string post, string country, string phone) : this(id, comname, contname, addy, city, reg, post, country, phone, "N/A")
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city, string reg, string post, string country) : this(id, comname, contname, addy, city, reg, post, country, "N/A", "N/A")
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city, string reg, string post) : this(id, comname, contname, addy, city, reg, post, "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city, string reg) : this(id, comname, contname, addy, city, reg, "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id, string comname, string contname, string addy, string city) : this(id, comname, contname, addy, city, "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id, string comname, string contname, string addy) : this(id, comname, contname, addy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id, string comname, string contname) : this(id, comname, contname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id, string comname) : this(id, comname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Customers(int id) : this(id, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Customer ID  : " + CustomerID + "\n";
            aMessage += aMessage + "Comapny Name : " + CompanyName + "\n";
            aMessage += aMessage + "Contact Name : " + ContactName + "\n";
            aMessage += aMessage + "Contact Title: " + ContactTitle + "\n";
            aMessage += aMessage + "Address      : " + Address + "\n";
            aMessage += aMessage + "City         : " + City + "\n";
            aMessage += aMessage + "Region       : " + Region + "\n";
            aMessage += aMessage + "Postal Code  : " + PostalCode + "\n";
            aMessage += aMessage + "Country       : " + Country + "\n";
            aMessage += aMessage + "Phone        : " + Phone + "\n";
            aMessage += aMessage + "Fax          : " + Fax + "\n";

            return aMessage;
        }
    }
}
