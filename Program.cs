using System;

namespace DogClassExample
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        // Unary overloaded operator ++ to increment the age of the dog
        public static Dog operator ++(Dog dog)
        {
            dog.Age++;
            return dog;
        }

        // Comparison overloaded operators == and != to compare the names of two dogs
        public static bool operator ==(Dog dog1, Dog dog2)
        {
            return dog1.Name == dog2.Name;
        }

        public static bool operator !=(Dog dog1, Dog dog2)
        {
            return !(dog1 == dog2);
        }

        // Comparison overloaded operators > and < to compare the weights of two dogs
        public static bool operator >(Dog dog1, Dog dog2)
        {
            return dog1.Weight > dog2.Weight;
        }

        public static bool operator <(Dog dog1, Dog dog2)
        {
            return dog1.Weight < dog2.Weight;
        }

        // Binary overloaded operator + to combine the weights of two dogs
        public static double operator +(Dog dog1, Dog dog2)
        {
            return dog1.Weight + dog2.Weight;
        }

        // Display method to show the dog's details
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}kg");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating two Dog objects
            Dog dog1 = new Dog { Name = "Kenobi", Age = 5, Weight = 9.1 };
            Dog dog2 = new Dog { Name = "Dublin", Age = 3, Weight = 20.3 };

            // Incrementing the age of dog1 using unary operator ++
            Console.WriteLine("After incrementing the age of dog1:");
            (++dog1).Display();

            // Comparing the names of dog1 and dog2 using overloaded operators == and !=
            Console.WriteLine($"Are the names of dog1 and dog2 the same? {dog1 == dog2}");
            Console.WriteLine($"Are the names of dog1 and dog2 different? {dog1 != dog2}");

            // Comparing the weights of dog1 and dog2 using overloaded operators > and <
            Console.WriteLine($"Is {dog1.Name} heavier than {dog2.Name}? {dog1 > dog2}");
            Console.WriteLine($"Is {dog1.Name} lighter than {dog2.Name}? {dog1 < dog2}");

            // Combining the weights of dog1 and dog2 using binary operator +
            Console.WriteLine($"Total weight of {dog1.Name} and {dog2.Name}: {dog1 + dog2}kg");
        }
    }
}
