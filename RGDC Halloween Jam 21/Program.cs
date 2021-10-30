using System;

/*
 * Text-Based Game because that's all we know how to do
 * Sacrificed visuals and gameplay (clever and lazy)
 */

namespace GameJamTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string fruit;
            ConsoleKeyInfo key;

            Console.WriteLine(
                "You awaken in a strange, barren land, devoid of all colorful\n" +
                "graphics, intuitive user interfaces, and enjoyable gameplay.\n" +
                "The developers sacrificed these things because they didn't\n" +
                "know how to implement them effectively.\n" +
                "Press [L] to look around."
                );
            do
            {
                key = Console.ReadKey(true);
            } while (key.KeyChar != 'l');

            Console.WriteLine(
                "All that can be seen is this strange creature.\n" +
                "[ :( ]\n" +
                "It appears sad, but upon seeing you, it smiles.\n" +
                "[ :) ]\n" +
                "It approaches you.");

            Console.Write("Give it a name: ");
            name = Console.ReadLine();
            Console.WriteLine(
                "You say the new name aloud, and {0} beams.\n" +
                "[ :)) ]\n" +
                "Literally, beams of light emerge from the creature, clearing\n" +
                "the fog of the console window.",
                name);

        }
    }
}
