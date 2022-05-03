using System;
using System.Collections.Generic;
using System.Text;

namespace _31mart
{
    internal class Student
    {
        private static int _no;
        public Student()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public string FullName { get; set; }
    }
}
