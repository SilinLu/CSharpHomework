using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Chapter5
{


    [Serializable]
    [Table("orderDetail")]
    public class OrderDetail
    {

        public Order Order { get; set; }
        public int Order_Num { get; set; }
        public Goods good { get; set; }
        public int Goods_Num { get; set; }
        public double Sum_Cost {//不需要存
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
