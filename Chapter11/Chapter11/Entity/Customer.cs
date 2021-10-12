using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11
{
    [Serializable]
    public class Customer
    {
        
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name;
        }

        public override string ToString()
        {
            return $"Customer's name:{Name}";
        }
    }
}
