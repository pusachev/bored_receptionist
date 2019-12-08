using System;
using Gym;

namespace bored_receptionist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            Gym.Gym gym = new Gym.Gym();

            while (showMenu)
            {
                showMenu = DisplayMenu(gym);
            }

        }

        private static bool DisplayMenu(Gym.Gym gym)
        {
            int menuChoise;

            Console.Clear();
            RenderFirstMenu();

            while (!Int32.TryParse(Console.ReadLine(), out menuChoise)) {
                Console.WriteLine("Please enter correct choice");
                RenderFirstMenu();
            }

            switch (menuChoise)
            {
                case 0:
                    return false;
                case 1:
                    AddClient(gym);
                    return true;
                case 2:
                    Train(gym);
                    return true;
                default:
                    return true;
            }
        }

        private static void RenderFirstMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("Add client[1]");
            Console.WriteLine("Train[2]");
            Console.WriteLine("Exit[0]");
            Console.WriteLine();
            Console.WriteLine("Please enter number: ");
        }

        private static void AddClient(Gym.Gym gym)
        {
            string name;
            int approach;
            bool NotValidString = true;

            Console.WriteLine("Please enter name: ");
            name = Console.ReadLine();

            NotValidString = String.IsNullOrEmpty(name);

            while (NotValidString)
            {
                Console.WriteLine("Please enter name: ");
                name = Console.ReadLine();
                NotValidString = String.IsNullOrEmpty(name);
            }

            Console.WriteLine("Please entrer approach:");

            while (!Int32.TryParse(Console.ReadLine(), out approach))
            {
                Console.WriteLine("Please enter valid approach: ");
            }

            IHumanInterface humanInterface = new Client(name, (uint)approach);

            gym.Add(humanInterface);

            Console.WriteLine("Client {0} add sucessfully Please press enter to continue", name);
            Console.ReadLine();
        }

        private static void Train(Gym.Gym gym)
        {
            gym.Train();

            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
        }
    }
}
