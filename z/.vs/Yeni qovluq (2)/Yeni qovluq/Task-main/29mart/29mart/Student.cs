using System;
using System.Collections.Generic;
using System.Text;

namespace _29mart
{
    internal class Student
    {
        public Student(string fullName, string groupNo, int age)
        {
            this.FullName = fullName;
            this.Age = age;
            this.GroupNo = groupNo;
        }

        private string _fullName;
        public string FullName
        {
            get => this._fullName;
            set
            {
                if (CheckFullName(value))
                {
                    this._fullName = value;
                }
            }
        }
        private string _groupNo;
        public string GroupNo
        {
            get => this._groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    this._groupNo = value;
                }
            }
        }
        public int Age { get; set; }
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {

                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                        return false;
                }
                return true;

            }
            return false;
        }
        public static bool CheckFullName(string fullname)
        {
            fullname = fullname.Trim();
            string[] words = fullname.Split(' ');
            if (words.Length == 2)
            {
                foreach (string word in words)
                {
                    if (!char.IsUpper(word[0]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
