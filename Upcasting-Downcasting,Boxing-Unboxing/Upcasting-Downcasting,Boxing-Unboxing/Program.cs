using Service.Extension;
using Service.Services;
using Service.Services.Interface;
using System;
using Upcasting_Downcasting_Boxing_Unboxing.Models;

namespace Upcasting_Downcasting_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Login();
            //int num = 4;
            //if (num < 0)
            //{
            //    Console.WriteLine("Duzgun eded daxil et");
            //    return;
            //}
            //Console.WriteLine(num.CalculateFactorial());
            #endregion

            //Eagle eagle1 = new Eagle();

            //Animal animal = eagle1;
            //Animal animal2 = new Eagle();
            //animal2.Eat();

            //int num1 = 5;
            //byte num2 =(byte) num1;
            //Console.WriteLine(num2);

            //int a = 12;
            //object b = a;
            //int c = (int)b;

            //Eagle eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Animal[] animals = { eagle1, eagle2, shark1, shark2 };
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //Shark shark2 = (Shark)shark1;


            Animal shark1 = new Shark();
            Animal eagle1 = new Eagle();
            object[] objects = { 11, 12, "Anar", shark1,eagle1 };
            foreach (var item in objects)
            {
                Animal animal = item as Animal;

                

                bool iscast = animal == null ? false : true;
                if (iscast)
                {
                    string result = animal.Name ?? "Bebir";
                    Console.WriteLine(result);
                }




                //if (animal == null)
                //{
                //    Console.WriteLine("can't casting");
                //}
                //else
                //{
                //    animal.Name = "test2";
                //    Console.WriteLine(animal.Name);
                //}



                //if(item is Animal)
                //{
                //    ((Animal)item).Name = "test";
                //    Console.WriteLine(((Animal)item).Name);
                //}
                //else
                //{
                //    Console.WriteLine("can't casting");
                //}

            }

        }
        
    //    static void Login()
    //    {
    //        Console.WriteLine("Add email:");
    //        string email = Console.ReadLine();
    //        Console.WriteLine("Add password:");
    //        string password = Console.ReadLine();
    //        int role = 1;
    //        IAccountService account = new AccountService();
    //        Console.WriteLine(account.Login(email, password, role));
    //    }
    }
}
