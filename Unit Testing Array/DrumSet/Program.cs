﻿static string Drum(decimal money, List<int> initialQuality, List<string> commands)
{
    List<int> usedQuality = initialQuality.ToList();

    foreach (string command in commands)
    {
        if (command == "Hit it again, Gabsy!")
        {
            return $"{string.Join(" ", usedQuality)}\nGabsy has {money:f2}lv.";
        }

        bool isParsed = int.TryParse(command, out int power);
        if (!isParsed)
        {
            throw new ArgumentException("Number did not parse correctly!");
        }

        for (int i = 0; i < usedQuality.Count; i++)
        {
            usedQuality[i] -= power;
            if (usedQuality[i] > 0)
            {
                continue;
            }

            int price = initialQuality[i] * 3;
            if (money - price > 0)
            {
                money -= price;
                usedQuality[i] = initialQuality[i];
            }
            else if (money - price <= 0)
            {
                initialQuality.RemoveAt(i);
                usedQuality.RemoveAt(i);
                i--;
            }
        }
    }

    throw new ArgumentException("Terminate command not given!");
}
decimal money = 100;
List<int> initialQuality = new List<int>() { 5, 8, 20 };
List<string> commands = new List<string>() { "1", "2", "Hit it again, Gabsy!" };
string result = Drum(money, initialQuality, commands);
Console.WriteLine(result);