namespace PokemonKlasseMedConstructor2
{
    internal class Program
    {
        static void Main()
        {
            var Pikachu = new Pokemon ( "Pikachu", 20, 21 );
            var Belzebub = new Pokemon ( "Belzebub", 11, 66 );
            var Guaram = new Pokemon ( "Guaram", 44, 50 );
            
            Pikachu.ShowPokemon();  //Eller hvis vi kaller egenskapene fra main() inn i en funksjon

            Console.WriteLine($"{Pikachu.Name} pokemon har {Pikachu.Health}hp og er level: {Pikachu.Level}");

            Belzebub.ShowPokemon(); //Eller hvis vi kaller egenskapene fra main() inn i en funksjon

            Console.WriteLine($"{Belzebub.Name} pokemon har {Belzebub.Health}hp og er level: {Belzebub.Level}");

            Guaram.ShowPokemon();   //Eller hvis vi kaller egenskapene fra main() inn i en funksjon

            Console.WriteLine($"{Guaram.Name} pokemon har {Guaram.Health}hp og er level: {Guaram.Level}");

        }
    }
}
