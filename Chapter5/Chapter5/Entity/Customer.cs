using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    [Serializable]
    public class Customer
    {
        
        public string Name { get; set; }
        
        public override string ToString()
        {
            return $"Customer's name:{Name}";
        }
    }
}
