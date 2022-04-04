using System;

namespace todo
{

    class Employee
    {
        private string _id;
        private string _name;
        private string _surname;
        public Employee(string id, string name, string surname)
        {
            _name = name;
            _surname = surname;
            Id = id;
        }

        public Employee(string id)
        {
            Id = id;
        }
        public Employee()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Id { get => _id; set => _id = value; }

        public static Employee[] employee = {
            new Employee("1","ahmet","mehmet"),
            new Employee("2","can","cem"),
            new Employee("3","ayşe","fatma"),
            new Employee("4","hayriye","haydi"),
        };
    }
}