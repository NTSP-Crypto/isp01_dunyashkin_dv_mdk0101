using System;

namespace Hierarchy03
{
    class Employee
    {
        protected int id;
        protected string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}, имя: {name}");
        }
    }
}
