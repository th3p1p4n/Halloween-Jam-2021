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

            Console.Clear();

            Console.WriteLine(
                "All that can be seen is this strange creature.\n" +
                "[ :( ]\n" +
                "It appears sad, but upon seeing you, it smiles.\n" +
                "[ :) ]\n" +
                "It approaches you.");

            Console.Write("Give it a name: ");
            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(
                "You say the new name aloud, and {0} beams.\n" +
                "[ :)) ]\n" +
                "Literally, beams of light emerge from the creature, clearing\n" +
                "the fog of the console window. \n" +
                "    \\     |     /\n" +
                "      \\   |   /\n" +
                "-- -- [ :)) ] -- --\n" +
                "      /   |   \\ \n" +
                "    /     |     \\\n" +
                "Press [L] to look around.",
                name);
            do
            {
                key = Console.ReadKey(true);
            } while (key.KeyChar != 'l');

            Console.Clear();

            Console.WriteLine(
                "You can now make out a tree in the distance.\n" +
                "              v .   ._, |_  .,\n" +
                "           `-._\\/  .  \\ /    |/_\n" +
                "               \\  _\\, y | \\//\n" +
                "         _\\_.___\\, \\/ -.\\||\n" +
                "           `7-,--.`._||  / / ,\n" +
                "           /'     `-. `./ / |/_.'\n" +
                "                     |    |//\n" +
                "                     |_    /\n" +
                "                     |-   |\n" +
                "                     |   =|\n" +
                "                     |    |\n" +
                "--------------------/ ,  . \\--------._\n" +
                "Press [C] to continue.");

            do
            {
                key = Console.ReadKey(true);
            } while (key.KeyChar != 'c');

            Console.Clear();

            Console.WriteLine(
                "After further investigation, you see it’s covered in assorted fruits.\n" +
                "Choose one: Apple, Banana, Pear");

            int choice = 0;
            while(choice == 0)
            {
                string input = Console.ReadLine().ToLower().Trim();
                switch (input)
                {
                    case "apple":
                        choice = 1;
                        Console.WriteLine(
                            " ,(.\n" +
                            "(   )\n" +
                            " `\"'");
                        break;
                    case "banana":
                        choice = 2;
                        Console.WriteLine(
                            " ,\n" +
                            " \\`.__.\n" +
                            "  `._,'");
                        break;
                    case "pear":
                        choice = 3;
                        Console.WriteLine(
                            "  (\n" +
                            " / \\\n" +
                            "(   )\n" +
                            " `\"'");
                        break;
                    default:
                        Console.WriteLine(
                            "That's not available.\n" +
                            "Choose one: Apple, Banana, Pear");
                        break;
                }
            }

            Console.WriteLine(
                "...\n" +
                $"Upon your return, {name} seems very excited. It jumps towards your hand.\n" +
                $"Press [F] to feed it.");

            do
            {
                key = Console.ReadKey(true);
            } while (key.KeyChar != 'f');
            Console.WriteLine(
                "... \n" +
                "It seems even happier.\n" +
                "[ :) ] <3\n" +
                "Press [C] to continue.");

            do
            {
                key = Console.ReadKey(true);
            } while (key.KeyChar != 'c');


        }
    }
}

