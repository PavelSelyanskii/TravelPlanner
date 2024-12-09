using System;
using System.Collections.Generic;

namespace TravelPlanner
{
    class Program
    {
        // Класс для представления города
        class City
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public string DishOrDrink { get; set; }
            public List<string> PlacesToVisit { get; set; }
            public string Continent { get; set; } // Добавляем информацию о континенте

            public City(string name, string country, string dishOrDrink, List<string> placesToVisit, string continent)
            {
                Name = name;
                Country = country;
                DishOrDrink = dishOrDrink;
                PlacesToVisit = placesToVisit;
                Continent = continent;
            }
        }

        // Класс для маршрута
        class Route
        {
            public City Departure { get; set; }
            public City Destination { get; set; }
            public string Transport { get; set; }
            public double Price { get; set; }

            public Route(City departure, City destination, string transport, double price)
            {
                Departure = departure;
                Destination = destination;
                Transport = transport;
                Price = price;
            }
        }

        static void Main(string[] args)
        {
            // Список городов
            List<City> cities = new List<City>
            {
                // Россия
                new City("Москва", "Россия", "Борщ", new List<string> { "Красная площадь", "Третьяковская галерея" }, "Евразия"),
                new City("Санкт-Петербург", "Россия", "Пирожки", new List<string> { "Эрмитаж", "Петропавловская крепость" }, "Евразия"),
                new City("Казань", "Россия", "Чак-чак", new List<string> { "Казанский Кремль", "Мечеть Кул-Шариф" }, "Евразия"),
                new City("Сочи", "Россия", "Шашлык", new List<string> { "Олимпийский парк", "Красная поляна" }, "Евразия"),
                new City("Владивосток", "Россия", "Краб", new List<string> { "Русский мост", "Золотой рог" }, "Евразия"),
                new City("Новосибирск", "Россия", "Пельмени", new List<string> { "Новосибирский зоопарк", "Театр оперы и балета" }, "Евразия"),

                // Беларусь
                new City("Минск", "Беларусь", "Драники", new List<string> { "Остров Слез", "Музей Великой Отечественной войны" }, "Евразия"),
                new City("Брест", "Беларусь", "Холодник", new List<string> { "Брестская крепость", "Беловежская пуща" }, "Евразия"),
                new City("Гродно", "Беларусь", "Клёцки", new List<string> { "Замковая гора", "Фарный костел" }, "Евразия"),
                new City("Могилев", "Беларусь", "Мачанка", new List<string> { "Площадь Славы", "Зоосад" }, "Евразия"),
                new City("Гомель", "Беларусь", "Сбитень", new List<string> { "Дворец Румянцевых-Паскевичей", "Парк Лошицкий" }, "Евразия"),
                new City("Витебск", "Беларусь", "Кисель", new List<string> { "Дом-музей Шагала", "Пушкинский мост" }, "Евразия"),

                // Канада
                new City("Торонто", "Канада", "Путин (Poutine)", new List<string> { "CN Tower", "Royal Ontario Museum" }, "Северная Америка"),
                new City("Монреаль", "Канада", "Багель", new List<string> { "Базилика Нотр-Дам", "Парк Мон-Руаяль" }, "Северная Америка"),
                new City("Ванкувер", "Канада", "Лосось", new List<string> { "Стэнли Парк", "Гастаун" }, "Северная Америка"),
                new City("Квебек", "Канада", "Туртьер", new List<string> { "Старый Квебек", "Шато Фронтенак" }, "Северная Америка"),
                new City("Оттава", "Канада", "Бобровый хвост", new List<string> { "Парламентский холм", "Rideau Canal" }, "Северная Америка"),
                new City("Калгари", "Канада", "Стейк", new List<string> { "Калгарийская башня", "Зоопарк Калгари" }, "Северная Америка"),

                // Китай
                new City("Пекин", "Китай", "Утка по-пекински", new List<string> { "Великая китайская стена", "Запретный город" }, "Азия"),
                new City("Шанхай", "Китай", "Димсамы", new List<string> { "Сад Юйюань", "Набережная Вайтань" }, "Азия"),
                new City("Гуанчжоу", "Китай", "Чайные пирожные", new List<string> { "Башня Гуанчжоу", "Чэньцзяцы" }, "Азия"),
                new City("Сиань", "Китай", "Ляньпянь", new List<string> { "Терракотовая армия", "Большая пагода диких гусей" }, "Азия"),
                new City("Чэнду", "Китай", "Острый хотпот", new List<string> { "Гигантская панда", "Монумент Дачжу" }, "Азия"),
                new City("Гонконг", "Китай", "Чай с молоком", new List<string> { "Пик Виктория", "Остров Лантау" }, "Азия"),

                // Казахстан
                new City("Алматы", "Казахстан", "Бешбармак", new List<string> { "Кок-Тобе", "Медео" }, "Евразия"),
                new City("Нур-Султан", "Казахстан", "Кумыс", new List<string> { "Байтерек", "Дворец мира и согласия" }, "Евразия"),
                new City("Шымкент", "Казахстан", "Лагман", new List<string> { "Парк Абая", "Этнопарк Кен-Баба" }, "Евразия"),
                new City("Атырау", "Казахстан", "Казы", new List<string> { "Уральский мост", "Достык" }, "Евразия"),
                new City("Караганда", "Казахстан", "Шубат", new List<string> { "Музей КарЛАГ", "Собор Святого Иосифа" }, "Евразия"),
                new City("Павлодар", "Казахстан", "Курт", new List<string> { "Экибастуз", "Горы Баян-Аул" }, "Евразия")
            };

            // Автоматическая генерация маршрутов
            List<Route> routes = new List<Route>();
            Random random = new Random();

            foreach (var city1 in cities)
            {
                foreach (var city2 in cities)
                {
                    if (city1 != city2)
                    {
                        // Если города находятся на разных континентах, то только самолет
                        string transport = city1.Continent == city2.Continent ?
                            (random.Next(0, 2) == 0 ? "Самолет" : "Поезд") : "Самолет";

                        double price = random.Next(20000, 150001); // Генерация цены от 3000 до 15000
                        routes.Add(new Route(city1, city2, transport, price));
                    }
                }
            }

            // Основной цикл программы
            while (true)
            {
                Console.WriteLine("Введите город отправления (или 'стоп' для завершения):");
                string departure = Console.ReadLine();

                // Завершаем программу по команде "стоп"
                if (departure.ToLower() == "стоп")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                Console.WriteLine("Введите город назначения:");
                string destination = Console.ReadLine();

                City departureCity = cities.Find(c => c.Name.Equals(departure, StringComparison.OrdinalIgnoreCase));
                City destinationCity = cities.Find(c => c.Name.Equals(destination, StringComparison.OrdinalIgnoreCase));

                if (departureCity == null || destinationCity == null)
                {
                    Console.WriteLine("Один из городов не найден.");
                    continue;
                }

                Route route = routes.Find(r => r.Departure == departureCity && r.Destination == destinationCity);

                if (route != null)
                {
                    Console.WriteLine($"Маршрут найден:\n{departureCity.Name} -> {destinationCity.Name}\nТранспорт: {route.Transport}, Цена: {route.Price} руб.");
                }
                else
                {
                    Console.WriteLine("Маршрут недоступен.");
                }

                Console.WriteLine($"Город назначения: {destinationCity.Name}");
                Console.WriteLine($"Рекомендуемое блюдо/напиток: {destinationCity.DishOrDrink}");
                Console.WriteLine("Места для посещения:");
                foreach (var place in destinationCity.PlacesToVisit)
                {
                    Console.WriteLine($"- {place}");
                }
            }
        }
    }
}
