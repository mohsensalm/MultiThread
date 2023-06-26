// See https://aka.ms/new-console-template for more information
using System;

using System.Threading;

namespace Threaddemo

{

    public class mainthread1
    {

        // static method one

        public static void thrd1()

        {

            // It prints numbers from 0 to 10

            for (int t = 0; t <= 10; t++)
            {

                Console.WriteLine("Thread1 is : {0}", t);

                // When the value of t is equal to

                // 5 then this method sleeps for

                // 5 seconds and after 5 seconds

                // it resumes its working

                if (t == 5)
                {

                    Thread.Sleep(5000);

                }

            }

        }

        // static method two

        public static void thrd2()

        {

            // It prints numbers from 0 to 10

            for (int p = 0; p <= 10; p++)
            {

                Console.WriteLine("Thread2 is : {0}", p);

            }

        }

    }

    // Driver Class

    public class mainthread2
    {

        // Main Method

        static public void Main()

        {

            // Calling static methods

            mainthread1.thrd1();

            mainthread1.thrd2();

        }

    }

}