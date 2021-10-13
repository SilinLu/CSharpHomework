using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chapter12
{


    [Serializable]
    [Table("orderDetails")]
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("good_GoodId")]
        public Good good { get; set; }
        public int Goods_Num { get; set; }
        public double Sum_Cost {//不需要存
            get {
                return good != null ? good.Unit_Price * Goods_Num:0 ;
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
            int hashCode = -864811469;
            hashCode = hashCode * -1521134295 + OrderDetailId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Order>.Default.GetHashCode(Order);
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Good>.Default.GetHashCode(good);
            hashCode = hashCode * -1521134295 + Goods_Num.GetHashCode();
            return hashCode;
        }
    }


}
