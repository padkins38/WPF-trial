using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Practices
{
    public class Student
    {

        public double SoonerID      {get; set;}

        public string FirstName     {get; set;}

        public string LastName      {get; set;}

        public bool IsOnProbation {get; set;}

        public double GPA           {get; set;}

        private double BursarBalance;

        /*public List<string> Majors { get; set; }

        public UniversityCourse Course { get; set; }*/

        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;
            /*Majors = new List<string>();
            Course = new UniversityCourse();*/
        }

        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount<0)
            {
                Console.WriteLine("invalid");
                throw new Exception("Amound must be greater than 0");
            }
            
            BursarBalance -= amount;
            //BursarBalance = BursarBalance - amount;
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}, ({SoonerID.ToString("N0")}";
        }

        /*public class UniversityCourse
        {

        }*/
    }

}
