using System;
using System.Collections.Generic;
using System.Text;



namespace Modelss
{
    public class MenuItem
    {
        public MenuItem()
        {
            _id++;
            No = _id;

        }
        private static int _id;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Catagory catagory1 { get; set; }


    }
}