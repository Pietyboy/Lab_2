/*При запуске программы пользователю предлагается справочная информация по использованию. Далее предлагается ввести команду, позволяющую выполнить одно из действий:

1) осуществить поиск музыкальной композиции в каталоге по определенному критерию
2) вывести информацию обо всех существующих в каталоге композициях
3) добавить информацию о композиции в каталог
4) удалить существующую в каталоге запись
5) выйти из программы

Критериями поиска могут служить: имя(название) автора / исполнителя или название композиции.
В качестве результата поиска в консоль должен выводиться список композиций в виде «исполнитель – название».
Удаление или добавление записи осуществляется после ввода всей информации о композиции.
*/

namespace Lab_2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Music_list catalog = new Music_list();

            bool endApp = false;

            Console.WriteLine("Usage:");
            Console.WriteLine("Type one of commands:");
            Console.WriteLine("\t\"list\" to display all items of catalog");
            Console.WriteLine("\t\"search\" to go find items in catalog");
            Console.WriteLine("\t\"add\" to add new item");
            Console.WriteLine("\t\"del\" to remove some item from catalog");
            Console.WriteLine("\t\"quit\" to exit");
            Console.Write("----");

            while (!endApp)
            {
                Console.WriteLine("\nInput the command:");
                switch (Console.ReadLine())
                {
                    case "list":
                        Console.WriteLine("All compositions in catalog:");
                        catalog.PrintList();
                        break;

                    case "search":
                        Console.WriteLine("Input the part of the name to find composition in the catalog:");
                        catalog.Search(Console.ReadLine());
                        break;

                    case "add":
                        Console.WriteLine("Input author's name:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Input the composition's name:");
                        string song = Console.ReadLine();
                        catalog.Add(author, song);
                        break;

                    case "del":
                        Console.WriteLine("Input the full name of the track to remove like that \"author-composition\":");
                        catalog.Del(Console.ReadLine());
                        break;

                    case "quit":
                        Console.WriteLine("Goodbye!");
                        endApp = true;
                        break;
                }
                Console.WriteLine("----");
            }
        }
    }
}