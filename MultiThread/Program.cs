// See https://aka.ms/new-console-template for more information

// C# program to illustrate the

// concept of Multithreading


public class mainthread
{

    // static method one

    public static void thrd1()

    {

        // It prints numbers from 0 to 10

        for (int x = 0; x <= 10; x++)
        {

            Console.WriteLine("Thread1 is : {0}", x);

            // When the x's value is equal to 5 then

            // this method sleeps for 5 seconds

            if (x == 5)
            {

                Thread.Sleep(5000);

            }

        }

    }

    // static method two

    public static void thrd2()

    {

        // It prints numbers from 0 to 10

        for (int y = 0; y <= 10; y++)
        {

            Console.WriteLine("Thread2 is : {0}", y);

        }

    }

    // Main Method

    static public void Main()

    {

        // Creating and initializing threads

        Thread t1 = new Thread(thrd1);

        Thread t2 = new Thread(thrd2);

        t1.Start();

        t2.Start();

    }

}