using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overload
{
    
    class House
    {
        public int Area { get; set; }
        public string Address { get; set; }
        public House(int area, string address)
        {
            Area = area;
            Address = address;
        }
        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }
        public House DeepClone()
        {
            return new House(Area, Address);
        }

        public override string ToString()
        {
            return $"Площа = {Area}, Адреса = {Address}";
        }
    }
}
