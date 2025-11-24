namespace classes_structs_oop
{
    internal class Program
    {
        public class Character
        {
            public string name;
            public int exp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
        }
    }
}