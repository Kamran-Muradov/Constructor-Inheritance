
namespace Constructor_Inheritance_Classwork
{
    internal class Fish : Animal
    {
        public string color;

        public Fish() : base("Just animal")
        {
            Console.WriteLine("Fish constructor");
        }
    }
}
