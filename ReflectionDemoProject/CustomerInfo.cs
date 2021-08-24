using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace ReflectionDemoProject
{
    public class CustomerInfo
    {
        public int ID
        {
            get;
            set;
        }
        public string NAME
        {
            get;
            set;
        }
        public CustomerInfo(int Id, string Name)
        {
            this.ID = Id;
            this.NAME = Name;
        }
        public CustomerInfo()
        {
            this.ID = -1;
            this.NAME = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("ID is {0}", this.ID);
        }
        public void PrintNAME()
        {
            Console.WriteLine("NAME is {0}", this.NAME);
        }
    }
}
