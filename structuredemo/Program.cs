using System;

namespace structuredemo
{
            public struct Person
        {
         
            public string Name;
            public int Age;
            public int Weight;

        }

        class samu1
        {

            static void Main(string[] args)
            {

                Person P1;
                P1.Name = "samiksha parag";
                P1.Age = 23;
                P1.Weight = 90;
                Console.WriteLine("Data Stored in P1 is " +
                                   P1.Name + ", age is " +
                                   P1.Age + " and weight is " +
                                   P1.Weight);

            }
        }

}

    