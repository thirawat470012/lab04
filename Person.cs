using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace lab04
{
    public class Person
    {
        private string name;
        private int age;
        private int BirthYear;
        private double gpa;

        public Person(string Name, int bYear , double GPA)
        {
            name = Name;
            this.BirthYear = bYear;
            age = 2565 - bYear;
            gpa = GPA;
            
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public double getGPA()
        {
            return gpa;
        }
    }
}
