using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Packt.Shared
{
    public class Person
    {
        public Person() { }

        public Person(decimal initialSalary)
        {
            Salary = initialSalary;
        }

        [XmlAttribute("fname")] // instead of child tag, it becomes an attribute of tag. Good for saving space
        public string FirstName { get; set; }
        [XmlAttribute("lname")]
        public string LastName { get; set; }
        [XmlAttribute("dob")]
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary { get; set; }
    }
}