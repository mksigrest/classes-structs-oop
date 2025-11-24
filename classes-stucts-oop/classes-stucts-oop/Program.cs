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

            public void PrintStatsInfo()
            {
                Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();
        }
    }
}