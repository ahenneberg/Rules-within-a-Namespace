/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NAME SCOPING
/* Names declared in outer namespaces can be used unqualified
 within inner namespaces. In this example, Class1 does not
 need qualificaiton within Inner: */
 namespace Outer
{
    class Class1 { }
    
    namespace Inner
    {
        class Class2 : Class1 { }
    }
}
/* If you want to refer to a type in a different branch or 
 your namespace hierarchy, you can use a partially qualified
 name. In the following example, we base SalesReport on
 Common.ReportBase: */
 namespace MyTradingCompany
{
    namespace Common
    {
        class ReportBase { }
    }
    namespace ManagementReporting
    {
        class SalesReport : Common.ReportBase { }
    }
}

// NAME HIDING
/*If the same type name appears in both an inner and an outer
 namespace, the inner name wins. To refer to the type in the
 outer namespace, you must qualify its name. For example: */
 namespace Outer
{
    class Foo { }

    namespace Inner
    {
        class Foo { }
        class Test
        {
            Foo f1;         // = Outer.Inner.Foo
            Outer.Foo f2;   // = Outer.Foo
        }
    }
}
/* All type names are converted to fully qualified names at
 compile time. Intermediate Language (IL) code contains no 
 unqualified or partially qualified names. */

// REPEATING NAMESPACES
/* You can repeat a namespace declaration, as long as the 
 type names within the namespaces don't conflict: */
/* We can even break the example into two source files such 
that we could compile each class into a different assembly. */
// Source file 1:
namespace Outer.Middle.Inner
{
    class Class1 { }
}
// Source file 2:
namespace Outer.Middle.Inner
{
    class Class2 { }
}
// NESTED USING DIRECTIVE
/* You can nest a using directive within a namespace. This 
 allows you to scope the using directive within a namespace
 declaration. In the following example, Class1 is visible
 in one scope, but not in another: */
 namespace N1
{
    class Class1 { }
}
namespace N2
{
    using N1;
    class Class2 : Class1 { }
}
namespace N2
{
    //class Class3 : Class1 // Compile-time error
}
namespace Rules_Within_A_Namespace
{
    class Program
    {
        static void Main()
        {

        }
    }
}
