using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class OrderDetail
    {
        private int orderID;
        private int productID;
        private int unitprice;
        private int quantity;
        private int discount;

        public int OrderID
        {
            get
            {
                return this.orderID;
            }
            set
            {
                this.orderID = value;
            }
        }
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
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
        public int Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }

        public OrderDetail()
        {

        }
        public OrderDetail(int oid, int pid, int uprice, int quant, int disc):this()
        {

        }
        public OrderDetail(int oid, int pid, int uprice, int quant) : this(oid, pid, uprice, quant, -1)
        {

        }
        public OrderDetail(int oid, int pid, int uprice):this(oid, pid, uprice, -1, -1)
        {

        }
        public OrderDetail(int oid, int pid):this(oid, pid, -1, -1, -1)
        {

        }
        public OrderDetail(int oid):this(oid, -1, -1, -1, -1)
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Order ID   : " + OrderID + "\n";
            aMessage += aMessage + "Product ID : " + ProductID + "\n";
            aMessage += aMessage + "Unit Price : " + UnitPrice + "\n";
            aMessage += aMessage + "Quantity   : " + Quantity + "\n";
            aMessage += aMessage + "Discount   : " + Discount + "\n";

            return aMessage;
        }
    }
}
