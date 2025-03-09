using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overload
{
    
    class Block
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public Block(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Block block = (Block)obj;
            return A == block.A && B == block.B && C == block.C && D == block.D;
        }
        public override string ToString()
        {
            return $"Block: A = {A}, B = {B}, C = {C}, D = {D}";
        }
    }
}
