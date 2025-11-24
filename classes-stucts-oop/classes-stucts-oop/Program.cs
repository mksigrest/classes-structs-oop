namespace classes_structs_oop
{
    internal class Program
    {
        public class Character
        {
            public string name;
            public int exp;

            public Character()
            {
                name = "Not assigned";
            }

            public Character(string name)
            {
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
        }
    }
}