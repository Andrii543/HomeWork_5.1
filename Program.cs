using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        try
        {
            Console.WriteLine("Впиши два числа");

            // Введення першого числа від користувача
            Console.Write("Перше число: ");
            decimal numOne = Convert.ToDecimal(Console.ReadLine());

            // Введення другого числа від користувача
            Console.Write("Друге число: ");
            decimal numTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Виберіть математичну дію");

            // Введення математичної дії від користувача
            Console.WriteLine("1: Додати (+) 2: Відняти (-) 3: Помножити (х) 4: Поділити (:)");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Змінна для збереження результата
            decimal result = 0;

            switch (userInput)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    result = numOne / numTwo; // Якщо numTwo == 0, тут виникне DivideByZeroException
                    break;
                default:
                    Console.WriteLine("Вибрана неправильна дія");
                    return;
            }

            Console.WriteLine($"\nРезультат: {result:F2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex.Message}");
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException - {ex.Message}");
        }
    }

}



