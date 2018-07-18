using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Employees
    {
        private int employeeID;
        private string lastname;
        private string firstname;
        private string title;
        private string titleofcourtesy;
        private DateTime birthdate;
        private DateTime hiredate;
        private string address;
        private string city;
        private string region;
        private string postalcode;
        private string country;
        private string homephone;
        private string extension;
        private string photo;
        private string notes;
        private int reportsto;

        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }
            set
            {
                this.employeeID = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string TitleofCourtesy
        {
            get
            {
                return this.titleofcourtesy;
            }
            set
            {
                this.titleofcourtesy = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return this.birthdate;
            }
            set
            {
                this.birthdate = value;
            }
        }
        public DateTime HireDate
        {
            get
            {
                return this.hiredate;
            }
            set
            {
                this.hiredate = value;
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
        public string HomePhone
        {
            get
            {
                return this.homephone;
            }
            set
            {
                this.homephone = value;
            }
        }
        public string Extension
        {
            get
            {
                return this.extension;
            }
            set
            {
                this.extension = value;
            }
        }
        public string Photo
        {
            get
            {
                return this.photo;
            }
            set
            {
                this.photo = value;
            }
        }
        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }
        public int ReportsTo
        {
            get
            {
                return this.reportsto;
            }
            set
            {
                this.reportsto = value;
            }
        }

        public Employees()
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country, string phone, string ext, string photo, string notes, int repsto):this()
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country, string phone, string ext, string photo, string notes) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, country, phone, ext, phone, notes, -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country, string phone, string ext, string photo) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, country, phone, ext, phone, "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country, string phone, string ext) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, country, phone, ext, "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country, string phone) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, country, phone, "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post, string country) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, country, "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg, string post) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, post, "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city, string reg) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, reg, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy, string city) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, city, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate, string addy) : this(id, last, first, title, titleofcourt, bdate, hdate, addy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate, DateTime hdate) : this(id, last, first, title, titleofcourt, bdate, hdate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt, DateTime bdate) : this(id, last, first, title, titleofcourt, bdate, default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title, string titleofcourt) : this(id, last, first, title, titleofcourt, default(DateTime), default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first, string title) : this(id, last, first, title, "N/A", default(DateTime), default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last, string first) : this(id, last, first, "N/A", "N/A", default(DateTime), default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id, string last) : this(id, last, "N/A", "N/A", "N/A", default(DateTime), default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }
        public Employees(int id):this(id, "N/A", "N/A", "N/A", "N/A", default(DateTime), default(DateTime), "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1)
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Employee ID      :   " + EmployeeID + "\n";
            aMessage += aMessage + "Last Name        :   " + LastName + "\n";
            aMessage += aMessage + "First Name       :   " + FirstName + "\n";
            aMessage += aMessage + "Title            :   " + Title + "\n";
            aMessage += aMessage + "Title of Courtesy:   " + TitleofCourtesy + "\n";
            aMessage += aMessage + "Birth Date       :   " + BirthDate + "\n";
            aMessage += aMessage + "Hire Date        :   " + HireDate + "\n";
            aMessage += aMessage + "Address          :   " + Address + "\n";
            aMessage += aMessage + "City             :   " + City + "\n";
            aMessage += aMessage + "Region           :   " + Region + "\n";
            aMessage += aMessage + "Postal Code      :   " + PostalCode + "\n";
            aMessage += aMessage + "Country          :   " + Country + "\n";
            aMessage += aMessage + "Home Phone       :   " + HomePhone + "\n";
            aMessage += aMessage + "Extension        :   " + Extension + "\n";
            aMessage += aMessage + "Photo            :   " + Photo + "\n";
            aMessage += aMessage + "Notes            :   " + Notes + "\n";
            aMessage += aMessage + "Reports To       :   " + ReportsTo + "\n";

            return aMessage;
        }
    }
}
