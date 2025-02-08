using System.Xml.Linq;

namespace AnimalInheritance
{
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }
    class Squirrel : Animal
    {
        public bool flying;
        public string fly;
        private string gender;
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
        public void setGender(string gender)
        { this.gender = gender; }
        public string getGender() { return this.gender; }
        public Squirrel()
            : base()
        {
            color = "";
            flying = false;
            gender = "";

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Animal cat = new Animal();
                cat.setName("Whiskers");
                cat.setType("cat");
                cat.color = "grey";
                Console.WriteLine($"I am a {cat.color} {cat.getType()} named {cat.getName()} \n");

                Squirrel squirrel = new Squirrel();
                squirrel.setName("Patrick");
                squirrel.setType("squirrel");
                squirrel.color = "red";
                squirrel.flying = true;
                squirrel.setGender("male");
                if (!squirrel.flying)
                {
                    Console.WriteLine($"My name is {squirrel.getName()} and I am a {squirrel.getGender()} {squirrel.color} {squirrel.getType()}. \nI am not a flying squirrel.");
                }
                else
                    Console.WriteLine($"My name is {squirrel.getName()} and I am a {squirrel.getGender()} {squirrel.color} {squirrel.getType()}. \nI am a flying squirrel!");
            }
        }
    }
}
