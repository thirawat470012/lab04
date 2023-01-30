using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Classroom
    {
        private string name;
        private List<Person> person = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }


        public void addPerson2Class(Person p)
        {
            this.person.Add(p);
        }

        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.person)
            {
                result += p.getName() + "\r\n";

            }
            return "";
        }
        public void addYearToClass(Person y)
        {
            person.Add(y);
        }
        public string showPersonon()
        {
            string result = "";
            foreach (Person p in person)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public void addYear2Class(Person y)
        {
            person.Add(y);
        }
        public string SumYear()
        {
            int year = 0;
            foreach (Person y in person)
            {
                int currentAge = year;
                int newTotalAge = currentAge + y.getAge();
                year = newTotalAge;
            }
            return year.ToString();
        }
        public void addGPA2Class(Person g)
        {
            person.Add(g);
        }
        public string GPAavg()
        {
            double totalGPA = 0;
            int count = 0;
            foreach (Person g in person)
            {
                totalGPA += g.getGPA();
                count++;
            }
            double avgGPA = totalGPA / count;
            return avgGPA.ToString();
        }
        public string MaxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return maxGPA.ToString();
        }
        public string MinGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return minGPA.ToString();
        }
        public string LessGPAname()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
        public string HightGPAname()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;

        }  
    }
}


