using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSeaPlane
{
   public class HangarOverflowException : Exception
    {       
            public HangarOverflowException() : base("В агаре нет свободных мест")
            { }
    }
}
