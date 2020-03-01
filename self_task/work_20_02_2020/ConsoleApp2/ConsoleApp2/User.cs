using System;

namespace ConsoleApp2
{
    class User
    {
        protected string name;
        protected int age;

        public User() { }
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void setName(string name)
        {
            if(name != null)
            {
                this.name = name;
            }
        }

        public string getName()
        {
            return name;
        }

        public void setAge (int age)
        {
            if(age > 0)
            {
                this.age = age;
            }
        }

        public int getAge()
        {
            return age;
        }
    }
}
