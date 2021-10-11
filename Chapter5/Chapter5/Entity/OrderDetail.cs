using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{


    [Serializable]
    public class OrderDetail
    {
        public Goods good { get; set; }
        public int Goods_Num { get; set; }
        public double Sum_Cost {
            get {
                return good.Unit_Price * Goods_Num;
            } 
                }
        public override string ToString()
        {
            return $"{good},quantity of good:{Goods_Num},total cost:{Sum_Cost}\n";
        }
        public override bool Equals(object obj)
        {
            OrderDetail details = obj as OrderDetail;
            return details != null && good.Name==details.good.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(good, Goods_Num);
        }
    }
}
