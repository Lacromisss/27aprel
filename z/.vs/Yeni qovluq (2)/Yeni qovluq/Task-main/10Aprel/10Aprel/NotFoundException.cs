using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
