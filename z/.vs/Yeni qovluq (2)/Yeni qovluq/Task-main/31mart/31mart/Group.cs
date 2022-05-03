using System;
using System.Collections.Generic;
using System.Text;

namespace _31mart
{
    internal class Group
    {

        private static int _noP = 100;
        private static int _noD = 100;
        private static int _noS = 100;
        private string _letterGroupNo = "";
        public Group(Groups type)
        {            
            this.Type = type;
            switch (type)
            {
                case Groups.Programming:
                    _noP++;
                    _letterGroupNo += ("P" + _noP);
                    break;
                case Groups.Design:
                    _noD++;                    
                    _letterGroupNo += ("D" + _noD);
                    break;
                case Groups.System:
                    _noS++;
                    _letterGroupNo += ("S" + _noS);
                    break;
            }
            this.No = _letterGroupNo;
        }
        public string No { get; }
        public Student[] students { get; set; }
        public Groups Type { get; set; }
        public Student FindStudentByNo(int no)
        {
            foreach (Student student in this.students)
            {
                if(student.No == no)
                {
                    return student;
                }
            }
            return null;
        }
    }
}

