using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Assignment_No11_Interfaces
{
    internal interface IOpen
    {
        // Fields
        const double _maxRotationalValue = 90;
        const double _minValue = 0;


        // Method Signature
        public void Open();
    }
}
