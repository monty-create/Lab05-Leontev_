using System;

int dayNumber = 5;
switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Будний");
        break;
}

Console.WriteLine();

int score = 78;
switch (score)
{
    case >= 0 and <= 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and <= 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and <= 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

Console.WriteLine();

int temp = 22;
string tempCategory = temp switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine(tempCategory);

Console.WriteLine();

string role = "teacher";
string access = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" => "Ограниченный доступ"
};
Console.WriteLine(access);

int age = 20;
bool hasTicket = false;
switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

Console.WriteLine();

int level = 2;
switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

Console.WriteLine();

// Задача А
Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine());
string season = month switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
Console.WriteLine(season);

Console.WriteLine();

// Задача Б
Console.Write("Введите возраст: ");
int userAge = int.Parse(Console.ReadLine());
string ageGroup = userAge switch
{
    < 0 => "Ошибка",
    <= 6 => "Ребёнок",
    <= 17 => "Подросток",
    <= 64 => "Взрослый",
    _ => "Пенсионер"
};
Console.WriteLine(ageGroup);

Console.WriteLine();

// Вариант 1
Console.Write("Введите номер месяца (1-12): ");
int m1 = int.Parse(Console.ReadLine());
string res1 = m1 switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
Console.WriteLine(res1);

Console.WriteLine();

// Вариант 3
Console.Write("Введите день недели: ");
string day3 = Console.ReadLine().Trim().ToLower();
string res3 = day3 switch
{
    "понедельник" or "вторник" or "среда" or "четверг" or "пятница" => "9:00–21:00",
    "суббота" => "10:00–20:00",
    "воскресенье" => "10:00–18:00",
    _ => "День не распознан"
};
Console.WriteLine(res3);
