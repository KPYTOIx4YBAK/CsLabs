using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Настройка игрового сервера ---");

        Console.Write("Введите название сервера: ");
        string name = Console.ReadLine();

        Console.Write("Максимум игроков: ");
        int maxPlayers = int.Parse(Console.ReadLine());

        Console.Write("Игроков онлайн: ");
        int onlinePlayers = int.Parse(Console.ReadLine());

        Console.Write("Всего памяти (ГБ): ");
        double maxRam = double.Parse(Console.ReadLine());

        Console.Write("Занято памяти (ГБ): ");
        double usedRam = double.Parse(Console.ReadLine());

        Console.Write("Пинг (мс): ");
        int ping = int.Parse(Console.ReadLine());

        Console.Write("База данных работает? (true или false): ");
        bool dbStatus = bool.Parse(Console.ReadLine());

        int freeSlots = maxPlayers - onlinePlayers;

        double playersPercent = ((double)onlinePlayers / maxPlayers) * 100;
        double ramPercent = (usedRam / maxRam) * 100;

        bool ramOk = ramPercent < 85;
        bool pingOk = ping < 100;
        bool serverReady = dbStatus && ramOk && pingOk;

        Console.WriteLine("\n--- ИТОГОВАЯ СВОДКА ---");
        Console.WriteLine("Сервер: " + name);
        Console.WriteLine("Свободных мест: " + freeSlots + " из " + maxPlayers);
        Console.WriteLine("Занято мест: " + playersPercent + "%");
        Console.WriteLine("Нагрузка на память: " + ramPercent + "%");
        Console.WriteLine("Пинг: " + ping + " мс");
        Console.WriteLine("База данных онлайн: " + dbStatus);

        Console.WriteLine("Можно запускать сервер? " + serverReady);
    }
}