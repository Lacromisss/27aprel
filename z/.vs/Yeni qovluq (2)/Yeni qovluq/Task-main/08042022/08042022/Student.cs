using System;
using System.Collections.Generic;
using System.Text;

namespace _08042022
{
    internal class Student
    {
        private static int _no;
        public Student()
        {
            _no++;
            this.No = _no;
        }
        public int No { get;  }
        public string FullName { get; set; }
        public Dictionary<string, double> Exams = new Dictionary<string, double>();
        public void AddExam(string examName,double point)
        {
            if (!string.IsNullOrEmpty(examName) && point>=0 && point<=100)
            {
                Exams.Add(examName, point);
            }
            else
            {
                throw new Exception("examName -null olmasin ! point 0-100 araliginda olmalidir!");
            }
           
        }
        public double GetExamResult(string examName)
        {
            if (!string.IsNullOrEmpty(examName))
            {
                if (Exams.ContainsKey(examName))
                {
                    return Exams[examName];
                }
                throw new Exception("Bele bir imtahan yoxdur !");
            }else
            {
                throw new Exception("examName -null olmasin !");
            }
        }
        public double GetExamAvg()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Value;
            }
            return sum / Exams.Count;
        }
    }
}

