using System;

namespace lab04
{
    public partial class Form1 : Form
    {
        Classroom classroom;

        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.tbname.Text;
            string input_year = this.tbbirth.Text;
            string input_GPA = this.GPA1.Text;
            int iYear = Int32.Parse(input_year);
            double GPA = Double.Parse(input_GPA);
            
            //create object from Person class
            Person person = new Person(input_name, iYear , GPA);
            //Show all person name
            listname.Text += person.getName() + "\t\t\t";
            //sum all person age
            int currentAge = Int32.Parse(this.tbtotal.Text);
            int newTotalAge = currentAge + person.getAge();
            this.tbtotal.Text = newTotalAge.ToString();
            this.classroom.addPerson2Class(person);
            this.listname.Text =
                classroom.showAllPersononClass();
            tbtotal.Text =
                classroom.SumAllYearClass();
            gpaavg.Text =
                classroom.avgMaxGPA();
            gpamax.Text =
                classroom.MaxGPA();
            gpamin.Text =
                classroom.MinGPA();
            textBox1.Text =
                classroom.maxGPAName();
            textBox2.Text =
                classroom.minGPAName();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}