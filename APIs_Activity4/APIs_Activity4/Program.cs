using System;

namespace Activity4
{
    // Interface and three types of properties
    interface Animal
    {
        string Name { get; set; }
        string Species { set; }
        int Age { get; }

        // Indexer
        int this[int i] { get; set; }

        // Instance method
        string AnimalInfo();
    }

    class Dog : Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }


        private int[] arr = new int[10];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public string AnimalInfo()
        {
            return (Name + " is " + Age + " years old.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Instance of class in main
            Dog snoopy = new Dog();
            snoopy.Age = 5;
            snoopy.Name = "Snoopy";
            Console.Write(snoopy.AnimalInfo());
        }
    }

}