Console.OutputEncoding = System.Text.Encoding.UTF8;

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// yaroslav.Health = 75;

// Console.WriteLine("»> Герой 1 «<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine("»> Герой 2 «<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine("»> Герой 3 «<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");

//Самостоятельное

Console.WriteLine("\nМой проект: Каталог игр");

Game game1 = new Game("Genshin  Impact", "ARPG", 2020, 9.8);
Game game2 = new Game("Майнкрафт", "Песочница", 2011, 9.0);
Game game3 = new Game("Mobile Legends Bang Bang", "MOBA", 2016, 8.5);

Console.WriteLine($"Игра 1: {game1.Title}, Жанр: {game1.Genre}, Год: {game1.Year}, Рейтинг: {game1.Rating}, Пройдена: {game1.Complete}");
Console.WriteLine($"Игра 2: {game2.Title}, Жанр: {game2.Genre}, Год: {game2.Year}, Рейтинг: {game2.Rating}, Пройдена: {game2.Complete}");
Console.WriteLine($"Игра 3: {game3.Title}, Жанр: {game3.Genre}, Год: {game3.Year}, Рейтинг: {game3.Rating}, Пройдена: {game3.Complete}");
