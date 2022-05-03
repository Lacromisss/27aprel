using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    internal class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string msg):base(msg)
        {

        }
    }
}
