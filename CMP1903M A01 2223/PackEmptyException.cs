using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //FOR SELF ASSESSMENT - this is an additional class (as well as error handling)
    internal class PackEmptyException : Exception
    {
        public PackEmptyException() : base(message: "Pack was empty!")
        {

        }
    }
}
