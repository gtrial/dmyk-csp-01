using System;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            //Создайте коллекцию, в которой бы хранились наименования 12 месяцев,
            //порядковый номер и количество дней в соответствующем месяце.
            //Реализуйте возможность выбора месяцев, как по порядковому номеру, так и количеству дней в месяце,
            //при этом результатом может быть не только один месяц.
            var months = new UserCollection {[0] = new Element("January", 1, 31)};
            Console.WriteLine(months[0].Name);
        }
    }
}