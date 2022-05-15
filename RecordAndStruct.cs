using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_and_S_and_LL
{
    internal class RecordAndStruct
    {

    }

    public record Pet(Int32 Weight);

    public record Cat(String Name, String Breed, String Color, Int32 Weight) : Pet(Weight)
    {

    }

   

    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
