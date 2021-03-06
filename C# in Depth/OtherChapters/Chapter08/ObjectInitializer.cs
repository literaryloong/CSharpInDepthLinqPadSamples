﻿using System.ComponentModel;

namespace Chapter08
{
    [Description("Listing 8.3")]
    class ObjectInitializer
    {
        static void Main()
        {
            Person tom = new Person
            {
                Name = "Tom",
                Age = 9,
                Home = { Town = "Reading", Country = "UK" },
                Friends =
                {
                    new Person { Name = "Alberto" },
                    new Person("Max"),
                    new Person { Name = "Zak", Age = 7 },
                    new Person("Ben"),
                    new Person("Alice")
                    {
                        Age = 9,
                        Home = { Town = "Twyford", Country="UK" }
                    }
                }
            };
        }
    }
}
