using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ReflectionDemoProject;

namespace ReflectionDemoProject
{
    public class ReflectionOnCustomer
    {
        public static void Test()
        {
            Type type = typeof(CustomerInfo);
            Console.WriteLine("Full Name:{0}", type.FullName);
            Console.WriteLine("Class Name:{0}", type.Name);
            Console.WriteLine("Method is Customer class");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReflectedType.Name + " " + method.Name);
            }
            Console.WriteLine("Properties in Customer class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.ReflectedType.Name + " " + property.Name);
            }
            Console.WriteLine("Constructor in Customer class");
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
