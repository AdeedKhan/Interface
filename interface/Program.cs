namespace Interface
{
    //internal class Program
    interface IAnimal //Base ClasS(Parent)
    {
        //static void Main(string[] args)
        void animalSound();
    }
    class Pig: IAnimal //Derived class (child)
    {
        public void animalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : IAnimal //Derived class (child)
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myPig = new Pig(); // Create a Pig object
            IAnimal myDog = new Dog(); // Create a Dog object

            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
