using System;
using System.Collections.Generic;
using System.Text;

namespace _30Mart1
{
    internal class Sheep:Animal
    {
        private static int _id;

        public Sheep()
        {
            _id++;
        }
        public string Type { get; set; }

    }
}
