using System;


namespace ClassesAndOOP
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "Horse McDonalds";
            sound = "host host";
        }

        public Animal(string name = "no name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
