using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   [ DataContractAttribute] /// ??????????????????
    public class Productik
    {
        public Productik(int ID, String name, String group, double price)
        {
            this.ID = ID;
            this.name = name;
            this.group = group;
            this.price = price;
        }
        
        public int ID;
        public String name;
        public String group;
        public double price;

    }
}
