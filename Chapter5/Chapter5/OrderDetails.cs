using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{


   
    class OrderDetails
    {
        public Goods good { get; set; }
        public int Goods_Num { get; set; }
        public double Sum_Cost {
            get;set; 
                }
        public override string ToString()
        {
            return $"{good.ToString()},quantity of good:{Goods_Num},total cost:{Sum_Cost}\n";
        }
        public override bool Equals(object obj)
        {
            OrderDetails details = obj as OrderDetails;
            return details != null && good.Name==details.good.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
