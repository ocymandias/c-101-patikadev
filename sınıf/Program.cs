using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            adam adam1 = new adam("ahmet","yılmaz",199,"aaa");
            adam1.sorgulama();
            Console.WriteLine("- - - - - - - - -");

            adam adam2 = new adam();
            adam2.name = "mehmet";
            adam2.surname = "öztürk";
            adam2.id = 1905;
            adam2.department = "bbbb";
            adam2.sorgulama();
            Console.WriteLine("- - - - - - - - -");

            adam adam3 = new adam("ahmet","yılmaz");
            adam3.sorgulama();

            Console.ReadLine();
        }
        class adam
        {
            public int id;
            public string name;
            public string surname;
            public string department;

            public adam(string name, string surname, int id, string department){
               this.name = name;
               this.surname = surname;
               this.id = id;
               this.department = department;

            }
            public adam(string name, string surname){
               this.name = name;
               this.surname = surname;

            }
            public adam(){}

            public void sorgulama()
            {
                Console.WriteLine("Employee name : {0}", name);
                Console.WriteLine("Employee surname : {0}", surname);
                Console.WriteLine("Employee id : {0}", id);
                Console.WriteLine("Employee department : {0}", department);

            }
        }
    }
}
