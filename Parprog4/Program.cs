namespace Parprog4;


// Appen du skal lage må ha en pokemontrener.
// Brukeren skal få velge navn og startpokemon.
// Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp.
// Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av).
// Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat.
// Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Pokemon pokeName = game.ChooseStartPokemon();
        Trainer trainer = new Trainer(name,  pokeName);
        trainer.PrintTrainerInfo();

        while (true)
        {
            game.Explore(trainer);
        }
    }
}