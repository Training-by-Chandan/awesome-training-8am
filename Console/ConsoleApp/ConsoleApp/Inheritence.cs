using System;

namespace ConsoleApp
{
    public class LivingThing
    {
        protected string _id;

        public LivingThing()
        {
        }

        public LivingThing(string id)
        {
            _id = id;
        }

        public LivingThing(int id)
        {
        }

        public void SomeFunction()
        {
            _id = "Something";
        }

        public virtual void Move()
        {
            Console.WriteLine("May or may not move");
        }
    }

    public class Animal : LivingThing
    {
        //if not mentioned it always calls default constructor (parameterless constructor)
        public Animal()
        {
        }

        public Animal(string id) : base(id)
        {
        }

        public Animal(int id) : base(id)
        {
        }

        //animal here is derived class or child class
        //livingthing is base class or parent class
        //important point to remember
        //1. Only one class is inherited to a class
        //2. protected is the keyword that makes the members public inside the family but private to outside world
        //3. public members can be accessed everywhere but private members are limited to only that class
        public void SomeAnimalFunction()
        {
            SomeFunction();
            _id = "";
        }

        //in order to override the base function needs to be either of one (virtual, abstract, override)
        public override void Move()
        {
            Console.WriteLine("Can move");
        }
    }

    public class Plant : LivingThing
    {
        public Plant() : base(0)
        {
        }

        public Plant(string id) : base(id)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Cannot move");
        }
    }

    public class HumanBeing : Animal
    {
        public HumanBeing() : base()
        {
        }
    }

    public class SomeHuman : Animal, IA, IB
    {
        public SomeHuman(string id) : base(id)
        {
        }
    }

    public interface IA
    {
    }

    public interface IB
    {
    }
}
