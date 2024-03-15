using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsandObjects
{
    // Define a public interface named IQuittable.
    // Any class inheriting the interface must provide an implementation of it's methods
    public interface IQuittable
    {
        void Quit(string reason);
    }
}

