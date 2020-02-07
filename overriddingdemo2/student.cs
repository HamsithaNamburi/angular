using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriddingdemo2
{
        abstract class student
        {
            public int studid;
            public String studname;
            public double examfee;
            public student(int studid, string studname, double examfee)
            {

                this.studid = studid;
                this.studname = studname;
                this.examfee = examfee;
            }
            public void DisplayDetails(int studid, string studname, double examfee)
            {
                Console.WriteLine("Student id is:" + studid);
                Console.WriteLine("student name is :" + studname);
                Console.WriteLine("Student Examfees is : " + examfee);
            }
            public abstract double Payfee();
        }
        class DayScholar : student
        {

            public DayScholar(int studid, string studname, double examfee) : base(studid, studname, examfee)
            {
            }

            public override double Payfee()
            {
                Console.WriteLine("Enter Transport fee : ");
                double TransportFee = Convert.ToDouble(Console.ReadLine());
                examfee = TransportFee + examfee;
                Console.WriteLine("Exam fee for Dayscholars is : " + examfee);
                return examfee;
            }
        }
        class Hosteller : student
        {
            //public double TransportFee = Convert.ToDouble(Console.ReadLine());
            public Hosteller(int studid, string studname, double examfee) : base(studid, studname, examfee)
            {
            }
            public override double Payfee()
            {
                // examfee = TransportFee + examfee;

                Console.WriteLine("Exam fee for Dayscholars is : " + examfee);
                return examfee;
            }
        }

    }
