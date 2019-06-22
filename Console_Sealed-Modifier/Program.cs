using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Note :
 We always used sealed-Modifier for (Derived-Class / Derived-Porperty / Derived-Method) :

    1.Derived-Class : to prevent any other class inherit from that base class
    2.Derived-Porperty : To prevent any other property override that virtual property in base class
    3.Derived-Method :  To prevent any other method override that virtual method in base class
 */


namespace Console_Sealed_Modifier
{
    // sealed-Modifier for Class
    class BaseClass { }
    sealed class DerivedClass : BaseClass { }
    // class NewClass : DerivedClass { }  -- Error : sealed-Keyword prevent any other class inherit from class B

    //-----------------------------------------------

    // sealed-Modifier for method/Property

    class BaseClss
    {
        public virtual int MyProperty { get; set; }  //sample Property
        public virtual void MyMethod() { }           //sample Method
    }
    class DerivedClss : BaseClss
    {
        public sealed override int MyProperty { get; set; }
        public sealed override void MyMethod() { }

    }
    class NewClss : DerivedClss
    {
        // public override int MyProperty { get; set; }  -- Error : sealed-Keyword  prevent any other property override that virtual property
        // public override void MyMethod() { }           -- Error : sealed-Keyword  prevent any other method override that virtual method
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
