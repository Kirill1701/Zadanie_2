using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Вэнь Екатерина Цзяцюаневна"; // Фамилия, имя, отчество
            byte age = 25; // Возраст
            string email = "kirvasilenko17@icloud.com"; // Электронный адрес
            double programmingScores = 72; // Баллы по программированию
            double mathScores = 68; // Баллы по математике
            double physicsScores = 80; // Баллы по физики

            string newPattern = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(newPattern,
                              FullName,
                              age,
                              email,
                              programmingScores,
                              mathScores,
                              physicsScores);
            Console.ReadKey();

            double totalPoints = programmingScores + mathScores + physicsScores; // Сумма баллов по всем предметам

            Console.WriteLine("Сумма баллов по всем предметам: " + totalPoints);
            Console.ReadKey();

            double averageScore = (programmingScores + mathScores + physicsScores) / 3; // Среднее арифметическое баллов

            Console.WriteLine("Среднее арифметическое баллов: " + "{0:00.00}", averageScore);
            Console.ReadKey();
        }
    }
}
