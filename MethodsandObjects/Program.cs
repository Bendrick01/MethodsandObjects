using System;

namespace MethodsandObjects
{
    class Program
    {
        static void Main()
        {
            // Employee (class) employee (variable) = (operator to assign a value to the variable) new (keyword to create instances of objects) Employee (constructor)
            // This demonstrates the concept of object instantiation and constructor usage.
            Employee employee = new Employee("Ben", "Issitt");

            // Demonstrate polymorphism by treating the employee instance as an IQuittable type.
            // This allows calling methods defined in the IQuittable interface on the employee object.
            IQuittable quit = employee;

            // Call the Quit method on the quit object, passing "New job" as the reason.
            // This shows how an object can use interface methods and how polymorphism enables interaction with objects through interface types.
            quit.Quit("New job");

            // Wait for a user input before closing the console window.
            Console.ReadLine();
        }
    }
}
