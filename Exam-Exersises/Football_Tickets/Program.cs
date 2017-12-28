using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyTotal = double.Parse(Console.ReadLine());
            var ticketType = Console.ReadLine();
            var supporters = int.Parse(Console.ReadLine());
            var normal = 249.99;
            var vip = 499.99;
            if((supporters >= 1 && supporters <= 4) && ticketType == "Normal")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.75);
                if (budgetLeft > (normal * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (normal * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (normal * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 5 && supporters <= 9) && ticketType == "Normal")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.60);
                if (budgetLeft > (normal * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (normal * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (normal * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 10 && supporters <= 24) && ticketType == "Normal")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.50);
                if (budgetLeft > (normal * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (normal * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (normal * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 25 && supporters <= 49) && ticketType == "Normal")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.40);
                if (budgetLeft > (normal * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (normal * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (normal * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 50) && ticketType == "Normal")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.25);
                if (budgetLeft > (normal * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (normal * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (normal * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 1 && supporters <= 4) && ticketType == "VIP")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.75);
                if (budgetLeft > (vip * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (vip * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (vip * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 5 && supporters <= 9) && ticketType == "VIP")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.60);
                if (budgetLeft > (vip * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (vip * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (vip * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 10 && supporters <= 24) && ticketType == "VIP")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.50);
                if (budgetLeft > (vip * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (vip * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (vip * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 25 && supporters <= 49) && ticketType == "VIP")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.40);
                if (budgetLeft > (vip * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (vip * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (vip * supporters) - budgetLeft);
                }
            }

            else if ((supporters >= 50) && ticketType == "VIP")
            {
                var budgetLeft = moneyTotal - (moneyTotal * 0.25);
                if (budgetLeft > (vip * supporters))
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", budgetLeft - (vip * supporters));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (vip * supporters) - budgetLeft);
                }
            }
        }
    }
}
