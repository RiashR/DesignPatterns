using InsuranceQuoteGenerator.Enums;

namespace InsuranceQuoteGenerator.Client
{
    // Console menu class
    public class ConsoleMenu
    {
        private InsuranceType[] options;
        private int selectedIndex = 0;

        public ConsoleMenu(InsuranceType[] options)
        {
            this.options = options;
        }

        public InsuranceType Run()
        {
            ConsoleKey key;

            do
            {
                Console.Clear();
                DisplayMessage("Please select the type of insurance below:");
                DisplayOptions();

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(options.Length - 1, selectedIndex + 1);
                        break;
                }

            } while (key != ConsoleKey.Enter);

            return options[selectedIndex];
        }

        private void DisplayOptions()
        {
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(options[i].GetDescriptiion());
            }

            Console.ResetColor();
        }

        private void DisplayMessage(string message)
        {
            Console.WriteLine($"{message}");
            Console.WriteLine(new string('-', message.Length));
        }
    }
}
