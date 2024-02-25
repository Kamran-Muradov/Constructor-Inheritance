
namespace Constructor_Inheritance_Classwork
{
    internal class Animal
    {
        public int id;
        public string name;

        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}

        public Animal(string text)
        {
            Console.WriteLine(text);
        }

        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
