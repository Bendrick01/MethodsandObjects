using System;
using System.Collections.Generic;
using System.Text;


namespace MethodsandObjects
{
    // Declare the Employee class and implement the IQuittable interface.
    // This indicates that the Employee class must provide implementations for all members declared in IQuittable.
    class Employee : IQuittable
    {
        // Define properties for FirstName and LastName with automatic getters and setters.
        // These properties store the first and last names of an Employee instance
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor for the Employee class that takes two strings: firstName and lastName.
        // This constructor initializes the Employee object with the provided names.
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implement the Quit method declared in the IQuittable interface.
        // This method takes a string reason and prints a message to the console indicating the employee is leaving and the reason.
        public void Quit(string reason)
        {
            Console.WriteLine($"{FirstName} {LastName} is leaving the business. The reason for this is : {reason}");
        }
    }
}
