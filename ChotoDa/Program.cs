namespace ChotoDa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Базовый алгоритм: Угадай число
           int maxAttempts = 10;
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Загадываем число от 1 до 100
            int attempts = 0;
            int userGuess = 0;

            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

            while (userGuess != secretNumber)
            {
                Console.Write("Твоя попытка: ");
                string input = Console.ReadLine();

                // Проверка корректности ввода
                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Пожалуйста, введите целое число!");
                    continue;
                }

                attempts++;

                if (attempts >= maxAttempts)
                {
                    Console.WriteLine($"К сожалению , попытки закончились! Загаданное число было: {secretNumber}");
                    break;
                }

                // Проверка числа
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Мое число БОЛЬШЕ!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Мое число МЕНЬШЕ!");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Ты угадал число {secretNumber} за {attempts} попыток!");
                }
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
    
}
