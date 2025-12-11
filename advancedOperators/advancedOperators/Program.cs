namespace advancedOperators
{


    class Player

    {
        public Player(string name, double healh, double exp)
        {
            Name = name;
            Health = Health;
            this.exp = exp;
        }

        string Name { get; set; }
        double Health { get; set; }
        double exp { get; set; }


        public static Player operator +(Player lhs, Player rhs)
        {
            return new Player(lhs.Name + rhs.Name, lhs.Health + rhs.Health , lhs.exp + rhs.exp);

        }
        public static Player operator ++(Player player)
        {
            player.Name = player.Name.ToUpper();
            player.Health += 1;
            player.exp += 1;
            return player;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Exp: {exp}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new("Amr", 99, 2);
            Player player2 = new("Ahmed", 70, 4);
            Player player3 = player1 + player2;

            ++player1;
            Console.WriteLine(player1);

            player2++;
            Console.WriteLine(player2);
        }
    }
}
