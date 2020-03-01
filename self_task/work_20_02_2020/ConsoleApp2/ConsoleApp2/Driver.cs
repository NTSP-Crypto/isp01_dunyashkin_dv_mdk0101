using System;

namespace ConsoleApp2
{
    class Driver : Worker
    {
        private int experience;
        private string driving_category;

        public Driver(string name, int age, int experience, string driving_category)
        {
            this.name = name;
            this.age = age;
            this.experience = experience;
            this.driving_category = driving_category;
        }

        public void setExperience(int experience)
        {
            this.experience = experience;
        }

        public int getExperience()
        {
            return experience;
        }

        public void setDriving_category(string driving_category)
        {
            this.driving_category = driving_category;
        }
    }
}
