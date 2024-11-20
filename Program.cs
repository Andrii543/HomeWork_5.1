using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;


        try
        {
            Console.WriteLine("Впиши два числа");

            //Введення першого числа від користувача
            Console.Write("Перше число: ");
            double numOne = Convert.ToDouble(Console.ReadLine());

            //Введення другого числа від користувача
            Console.Write("Друге число: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Виберіть математичну дію");

            //Введення математичної дії від користувача
            Console.WriteLine("1:Додати(+) 2:Відняти(-) 3:Помножити(х) 4:Поділити(:) ");
            int userInput = Convert.ToInt32(Console.ReadLine());


            //Змінна для верефікації чи користувач ввів 0 обравши дію ділення, бо на 0 ділити не можливо
            bool Verefication = true;
            if (userInput == 4 && numTwo == 0)
            {
                Console.WriteLine("Ділення на 0 не можливе");
                Verefication = false;
            }

            //змінна для збереження результата

            if (Verefication == true)
            {
                //змінна для збереження результата
                decimal result = 0;


                switch (userInput)
                {
                    case 1:
                        result = (decimal)(numOne + numTwo);
                        break;
                    case 2:
                        result = (decimal)(numOne - numTwo);
                        break;
                    case 3:
                        result = (decimal)(numOne * numTwo);
                        break;
                    case 4:
                        result = (decimal)(numOne / numTwo);
                        break;
                    default:
                        Console.WriteLine("Вибрана неправильна дія");
                        break;
                }

                Console.WriteLine($"\nРезультат {result:F2}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex.Message}");
        }

        throw new ArgumentException("Ділення на 0 не можливе");

    }
}