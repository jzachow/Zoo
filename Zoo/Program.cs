using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, any other key to quit");

            while (true)
            {
                char keyChar = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"You pressed {keyChar}");

                switch (keyChar)
                {
                    case '1':
                        lucinda.WhoAmI();
                        break;
                    case '2':
                        lloyd.WhoAmI();
                        break;
                    case '3':
                        SwapElephants(lucinda, lloyd);
                        break;
                    case '4':
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                        break;
                    case '5':
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd");
                        break;
                    default:
                        return;
                }
            }
            


        }

        public static void SwapElephants(Elephant firstElephant, Elephant secondElephant)
        {
            Elephant tempElephant = new Elephant();

            tempElephant = firstElephant;
            firstElephant = secondElephant;
            secondElephant = tempElephant;

            Console.WriteLine("References have been swapped");
        }
    }
}
