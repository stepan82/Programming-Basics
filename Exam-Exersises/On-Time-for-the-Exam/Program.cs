using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrive = int.Parse(Console.ReadLine());
            var minuteArrive = int.Parse(Console.ReadLine());
            int lateMoreHour = (((hourArrive * 60) + minuteArrive) - ((hourExam * 60) + minuteExam));
            var earlyMoreHour = ((((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)));
            var hour = lateMoreHour / 60;
            var minute = lateMoreHour - (hour*60);
            var hour_1 = earlyMoreHour / 60;
            var minute_1 = earlyMoreHour - (hour_1*60);

            //on time
            if (hourExam == hourArrive && minuteArrive == minuteExam)
            {
                Console.WriteLine("On time");
            }
            else if (((hourExam * 60) + minuteExam) > ((hourArrive * 60) + minuteArrive) && (((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", (((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)));
            }

            //late
            else if (((hourExam * 60) + minuteExam) < ((hourArrive * 60) + minuteArrive)
                && (((hourArrive * 60) + minuteArrive)-((hourExam * 60) + minuteExam)) < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", (((hourArrive * 60) + minuteArrive) - ((hourExam * 60) + minuteExam)));
            }

            else if (((hourExam * 60) + minuteExam) < ((hourArrive * 60) + minuteArrive)
                && (((hourArrive * 60) + minuteArrive) - ((hourExam * 60) + minuteExam)) > 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1} hours after the start", hour, minute);
            }

            //early
            else if (((hourExam * 60) + minuteExam) > ((hourArrive * 60) + minuteArrive) && ((((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)) > 30 && (((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)) < 60))
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", (((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)));
            }

            else if (((hourExam * 60) + minuteExam) > ((hourArrive * 60) + minuteArrive) && ((((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)) > 60))
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", hour_1, minute_1);
            }

            else if (((hourExam * 60) + minuteExam) > ((hourArrive * 60) + minuteArrive) && ((((hourExam * 60) + minuteExam) - ((hourArrive * 60) + minuteArrive)) == 60))
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:00 hours before the start", hour_1);
            }


        }
    }
}
