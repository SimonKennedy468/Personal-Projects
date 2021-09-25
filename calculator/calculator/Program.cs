using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string question = Console.ReadLine();
                float ans = 0;
                float num1;
                float num2;
                int opPos;
                int i;
                switch (question)
                {
                    case string add when add.Contains("+"):
                        opPos = add.IndexOf("+");
                        num1 = float.Parse(add.Substring(0, opPos));
                        num2 = float.Parse(add.Substring(opPos + 1));
                        ans = num1 + num2;
                        Console.WriteLine(ans);
                        break;

                    case string sub when sub.Contains("-"):
                        opPos = question.IndexOf("-");
                        num1 = float.Parse(sub.Substring(0, opPos));
                        num2 = float.Parse(sub.Substring(opPos + 1));
                        ans = num1 - num2;
                        Console.WriteLine(ans);
                        break;

                    case string mult when mult.Contains("*"):
                        opPos = mult.IndexOf("*");
                        num1 = float.Parse(mult.Substring(0, opPos));
                        num2 = float.Parse(mult.Substring(opPos + 1));
                        ans = num1 * num2;
                        Console.WriteLine(ans);
                        break;

                    case string div when div.Contains("/"):
                        opPos = div.IndexOf("/");
                        num1 = float.Parse(div.Substring(0, opPos));
                        num2 = float.Parse(div.Substring(opPos + 1));
                        ans = num1 / num2;
                        Console.WriteLine(ans);
                        break;

                    case string sqr when sqr.Contains("^"):
                        opPos = sqr.IndexOf("^");
                        num1 = float.Parse(sqr.Substring(0, opPos));
                        num2 = float.Parse(sqr.Substring(opPos + 1));
                        ans = 1;
                        for (i = 0;i < num2;i++)
                        {
                            ans = ans * num1;
                        }
                        ;
                        Console.WriteLine(ans);
                        break;

                    default:
                        Console.WriteLine("bad input");
                        break;
                }
            }
        }
    }
}
