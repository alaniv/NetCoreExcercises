using System;

using System.Collections.Generic;

using static System.Console;
/*
From the book:

private 
Member is accessible inside the type only. This is the default.

internal 
Member is accessible inside the type and any type in the same
assembly.

protected 
Member is accessible inside the type and any type that inherits from
the type.

public 
Member is accessible everywhere.

internal protected 
Member is accessible inside the type, any type in the same
assembly, and any type that inherits from the type. Equivalent
to a fictional access modifier named internal_or_protected.

private protected
Member is accessible inside the type, or any type that inherits from
the type and is in the same assembly. Equivalent to a fictional access
modifier named internal_and_protected. This combination is
only available with C# 7.2 or later.
*/

namespace Packt.Shared
{
    public partial class Person //partial split in 2 files
    {
        // constants
        public const string Species = "Homo Sapien";
        // read-only fields
        public readonly string HomePlanet = "Earth";

        // readonly vs const ? (...)

        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public readonly DateTime Instantiated;
        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(
        string command = "Run!",
        double number = 0.0,
        bool active = true)
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command, arg1: number, arg2: active);
        }
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;
            // increment each parameter
            x++;
            y++;
            z++;
        }
    }
}
