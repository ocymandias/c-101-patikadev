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
           
            
            adam adam1 = new adam();
            adam1.name = "ahmet";
            adam1.surname = "yılmaz";
            adam1.id = 199;
            adam1.department = "aaa";
            adam1.sorgulama();
            Console.WriteLine("- - - - - - - - -");

            adam adam2 = new adam();
            adam2.name = "mehmet";
            adam2.surname = "öztürk";
            adam2.id = 1905;
            adam2.department = "bbbb";
            adam2.sorgulama();
            Console.WriteLine("- - - - - - - - -");

            Console.ReadLine();
        }
        class adam
        {
            public int id;
            public string name;
            public string surname;
            public string department;

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
