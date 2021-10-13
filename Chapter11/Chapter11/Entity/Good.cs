using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11
{
    [Serializable]
    public class Good
    {
        public int GoodId { get; set; }
        public string Name { get; set; }
        public double Unit_Price { get; set; }
        public Good(string name,double price)
        {
            Name = name;
            Unit_Price = price;
        }
        public Good() { }
        public override string ToString()
        {
            return $"Good:{Name},Unit price:{Unit_Price}";
        }
    }
}
