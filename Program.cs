using System;

namespace methodCall_Input
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // calling a method
            NamePets("aasis", "sap");
            VisitPlanets(numberOfPlanets: 3); //method call with particular para.
        }

        static void NamePets() //defining method
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }

        static void NamePets(string pet1, string pet2)
        {
            Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
        }

        static void NamePets(string pet1, string pet2, string pet3)
        {
            Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
        }

        static void VisitPlanets( //calling method with optional parameter
          string adjective = "brave",
          string name = "Cosmonaut",
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }

    }
}

