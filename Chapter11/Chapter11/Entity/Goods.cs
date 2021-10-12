using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11
{
    [Serializable]
    public class Goods
    {
        public string Name { get; set; }
        public double Unit_Price { get; set; }
        public Goods(string name,double price)
        {
            Name = name;
            Unit_Price = price;
        }
        public Goods() { }
        public override string ToString()
        {
            return $"Goods:{Name},Unit price:{Unit_Price}";
        }
    }
}
