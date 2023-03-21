using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Ass1
{
    public class BagEmptyException : Exception
    {
        public BagEmptyException(string message) : base(message)
        {

        }
    }
    public class ElementNotInBagException : Exception
    {
        public ElementNotInBagException(string message) : base(message)
        {

        }
    }
}
