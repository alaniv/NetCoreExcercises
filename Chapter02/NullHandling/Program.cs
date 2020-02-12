#nullable enable

using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int thisCannotBeNull = 4;
            //thisCannotBeNull = null; // compile error!
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());


            var address = new Address();
            address.Building = null;
            address.City = "London";
            //address.Region = null;

            int? y = address.Building?.Length; //nullconditional operator : null val
            var result = address.Building?.Length ?? 3; // null-coalescing operator : default val

        }
    }
}
