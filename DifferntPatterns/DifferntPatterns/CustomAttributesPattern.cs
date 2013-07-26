using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    //Custom attribute
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct,
                           AllowMultiple = false)]

    public class MyAttribute : System.Attribute
    {
        public string data;

        public MyAttribute(string data)
        {
            this.data = data;
        }
    }

    [MyAttribute("MyAttributeValue")]
    class MyClass
    {
       
        public void GetInfo()
        {
            MyAttribute attribute = (MyAttribute)Attribute.GetCustomAttribute(typeof(MyClass), typeof(MyAttribute));
            Console.WriteLine("{0}", attribute.data); 
        }
    }


    //Obsolete attribute


    class CustomAttributesPattern
    {
        public CustomAttributesPattern()
        {
            Console.WriteLine("CustomAttributesPattern");

            var MyObject = new MyClass();

            MyObject.GetInfo();
        }
    }
}
