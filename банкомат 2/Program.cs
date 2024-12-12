using System;

class Program
{
    static void Main()
    {
        decimal balance = 10000;

      
        
            Console.WriteLine("\nДобро пожаловать в банкомат!");
            Console.WriteLine("1. Показать баланс");
            Console.WriteLine("2. Снять деньги");
            Console.WriteLine("3. Выйти");

            Console.Write("Выберите опцию (1/2/3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"Ваш баланс: {balance} рублей");
            }
            else if (choice == "2")
            {
                Console.Write("Введите сумму для снятия: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                if (amount > balance)
                {
                    Console.WriteLine("Недостаточно средств на счете.");
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("Сумма для снятия должна быть больше 0.");
                }
                else
                {
                    balance -= amount;  
                    Console.WriteLine($"Вы сняли {amount} рублей. Остаток: {balance} рублей.");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Спасибо, что воспользовались банкоматом!");
               
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
            }
        
    }
}
