using System;
using System.Collections.Generic;
using System.Text;
using System.Order;

namespace TshirtApp
{
    class Order
    {
        public class Order
        { 
            [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string DateOfOrder { get; set; }
            public string TshirtSize { get; set; }

            public string TshirtColor { get; set; }
            public string ShippingAddress { get; set; }




            public override string ToString()
            {
                return Name;
            }
        }
    }
}
