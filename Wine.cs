using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_and_S_and_LL
{
    public class Wine
    {
       public WineYear WineYear { get; set; }
       public WineColor WineColor { get; set; }
    }
    public enum WineColor
    {
        White,
        Red,
        Rose
    }

    public enum WineYear
    {
        NineteenNinetyOne,
        TwentyFive,
        TwentyNineteen
    }
}
