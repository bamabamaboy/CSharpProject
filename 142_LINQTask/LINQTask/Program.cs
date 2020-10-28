using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTask {
    class Program {
        static void Main(string[] args) {

            //LINQ - язык запросов к источнику данных, который реализует интерфейс IEnumerable

            Console.WriteLine("--------------------------------------------------------");

            //Пример использования LINQ
            example0ne();
            
            Console.WriteLine("--------------------------------------------------------");
            
            //Пример использования выборки сложных объектов
            exampleTwo();

            Console.WriteLine("--------------------------------------------------------");

            Console.ReadKey();
        }


        private static void example0ne() {
            
            //Рабочий массив данных
            string[] teams = { "Барселона", "Челси", "Краснодар", "Локомотив", "Бавария", "Боруссия" };

            Console.Write("Рабочик массив: ");
            foreach (string team in teams) Console.Write("{0} ", team);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------");

            //Работа с массивом обычным способом
            var selectedTeams1 = new List<string>();
            foreach (string team in teams) if (team.ToUpper().StartsWith("Б")) selectedTeams1.Add(team);

            selectedTeams1.Sort();

            foreach (string team in selectedTeams1) Console.Write("{0} ", team);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------");

            //Работа с массивом с помощью запроса LINQ
            var selectedTeams2 = from team in teams                        //Определем каждый отдельный объект из массива teams, для дальнейшей работы
                                 where team.ToUpper().StartsWith("Б")      //Условие фильтрации по критерию
                                 orderby team                              //Сортировка по возрастанию
                                 select team;                              //Выбираем объекты

            foreach (string team in selectedTeams2) Console.Write("{0} ", team);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------");

            //Работа с массивом с помощью методов расширения LINQ
            //В качестве аргумента методы принимают делегат или лямбда-выражение
            var selectedTeams3 = teams.Where(team => team.ToUpper().StartsWith("Б")).OrderBy(team => team);

            foreach (string team in selectedTeams3) Console.Write("{0} ", team);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------");

            //Сочетание двух подходов - запрос LINQ и метод расширения LINQ - Count()
            int teamsCount = (from team in teams select team).Count();
            Console.WriteLine("Кол-во команд - {0}", teamsCount);

            //Список методов расширения LINQ:

            //Select(), Where(), OrderBy(), OrderByDescending(), ThenBy(), ThenByDescending(),
            //Join(), GroupBy(), ToLookup(), GroupJoin(), Reverse(), All(), Any(), Contains(),
            //Distinct(), Except(), Union(), Intersect(), Count(), Sum(), Average(), Min(),
            //Max(), Take(), Skip(), TakeWhile(), Concat(), Zip(), First(), FirstOrDefault(),
            //Single(), SingleOrDefault(), ElementAt(), ElementAtOrDefault(), Last(), LastOrDefault()
        
        }

        private static void exampleTwo() {

            //Создадим массив объектов класса User
            List<User> users = new List<User>();

            users.Add(new User { Name = "Александр", Age = 25, Languages = new List<string> { "английский", "французкий" } });
            users.Add(new User { Name = "Сергей", Age = 38, Languages = new List<string> { "русский" } });
            users.Add(new User { Name = "Марат", Age = 83, Languages = new List<string> { "немецкий", "английский", "болгарский", "латинский" } });
            users.Add(new User { Name = "Вовка", Age = 15, Languages = new List<string> { "родной" } });

            //Достаним из массива только те объекты, у которых возраст > 20
            var selectedUsers = users.Where(user => user.Age > 20);

            //Выведем полученный результат в Консоль
            foreach (User user in selectedUsers) Console.Write("{0} ({1}), ", user.Name, user.Age);
            Console.WriteLine();
        }


    }
}
