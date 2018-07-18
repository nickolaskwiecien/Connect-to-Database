using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Shippers
    {
        private int shipperid;
        private string companyname;
        private string phone;

        public int ShipperID
        {
            get
            {
                return this.shipperid;
            }
            set
            {
                this.shipperid = value;
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

        public Shippers()
        {

        }
        public Shippers(int id, string compname, string phone) : this()
        {

        }
        public Shippers(int id, string compname) : this(id, compname, "N/A")
        {

        }
        public Shippers(int id) : this(id, "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Shipper ID  : " + ShipperID + "\n";
            aMessage += aMessage + "Company Name: " + CompanyName + "\n";
            aMessage += aMessage + "Phone       : " + Phone + "\n";

            return aMessage;
        }
    }
}
