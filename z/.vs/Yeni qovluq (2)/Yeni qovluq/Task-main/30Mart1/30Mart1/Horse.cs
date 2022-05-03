using System;
using System.Collections.Generic;
using System.Text;

namespace _30Mart1
{
    internal class Horse:Animal
    {
        private static int _id;

        public Horse()
        {
            _id++;
        }
        public string Type { get; set; }
    }
}
