using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_1_lc_0920_interface_delegate_event_lambda
{
    public class Student:Person, IMIS3033
    {

        public string stuID { get; set; }

        public double FinishExercise(double time)
        {
            Console.WriteLine("I worked hard to prepare for the exercise");
            return 90.6;
        }

        public double FinishHomework(double time)
        {
            Console.WriteLine("I worked hard to finish the homework");
            return 96.6;
        }
    }
}
