using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
namespace PaswordBreaker.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int exit = 0;
            Random rnd = new Random();
            char[] myphabet = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'ı', 'o', 'p', 'ğ', 'ü', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'ş', 'i', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'ö', 'ç', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string broke;

            char[] three = new char[3];
            char[] four = new char[4];
            char[] five = new char[5];
            char[] six = new char[6];

            #region same words base
            //List<string> threelist = new List<string>();
            //List<string> fourlist = new List<string>();
            //List<string> fivelist = new List<string>();
            //List<string> sixlist = new List<string>();
            #endregion

            Console.WriteLine("Enter Your Weak Password: ");
            string pas = Console.ReadLine();

            string start = DateTime.Now.ToString();
            
            for (; ;)
            {
                three[0] = myphabet[rnd.Next(42)];
                three[1] = myphabet[rnd.Next(42)];
                three[2] = myphabet[rnd.Next(42)];

                four[0] = myphabet[rnd.Next(42)];
                four[1] = myphabet[rnd.Next(42)];
                four[2] = myphabet[rnd.Next(42)];
                four[3] = myphabet[rnd.Next(42)];

                five[0] = myphabet[rnd.Next(42)];
                five[1] = myphabet[rnd.Next(42)];
                five[2] = myphabet[rnd.Next(42)];
                five[3] = myphabet[rnd.Next(42)];
                five[4] = myphabet[rnd.Next(42)];

                six[0] = myphabet[rnd.Next(42)];
                six[1] = myphabet[rnd.Next(42)];
                six[2] = myphabet[rnd.Next(42)];
                six[3] = myphabet[rnd.Next(42)];
                six[4] = myphabet[rnd.Next(42)];
                six[5] = myphabet[rnd.Next(42)];


                #region Dont Try Same Words

                //if (threelist.Contains(new string(three)))
                //{
                //    continue;
                //}
                //if (fourlist.Contains(new string(four)))
                //{
                //    continue;
                //}
                //if (fivelist.Contains(new string(five)))
                //{
                //    continue;
                //}
                //if (sixlist.Contains(new string(six)))
                //{
                //    continue;
                //}

                //threelist.Add(new string(three));
                //fourlist.Add(new string(four));
                //fivelist.Add(new string(five));
                //sixlist.Add(new string(six));
                #endregion

                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    {
                        broke = new string(three);
                        Console.WriteLine(broke);
                        #region site
                        if (pas == broke)
                        {
                            Console.WriteLine(" Password Broken = Password is :" + broke);
                            exit = 1;
                            break;
                        } 
                        #endregion
                    }
                    else if (i == 1)
                    {
                        broke = new string(four);
                        Console.WriteLine(broke);
                        if (pas == broke)
                        {
                            Console.WriteLine(" Password Broken = Password is :" + broke);
                            exit = 1;
                            break;
                        }
                    }
                    else if (i == 3)
                    {
                        broke = new string(five);
                        Console.WriteLine(broke);
                        if (pas == broke)
                        {
                            Console.WriteLine(" Password Broken = Password is :" + broke);
                            exit = 1;
                            break;
                        }
                    }
                    else if (i == 4)
                    {
                        broke = new string(six);
                        Console.WriteLine(broke);
                        if (pas == broke)
                        {
                            Console.WriteLine(" Password Broken = Password is :" + broke);
                            exit = 1;
                            break;
                        }
                    }
                }

                if (exit == 1)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            string finish = DateTime.Now.ToString();
            Console.WriteLine($"\n\n{start}\n{finish}\n\nWe have a victory!!!\nLast attempt successful");
        }
    }
}
