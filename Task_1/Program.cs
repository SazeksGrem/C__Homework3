Console.WriteLine("Ведите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


{

    int lastNum = num % 10;
    int firstNum = num / 10000;
    if (firstNum == lastNum)
    {
        lastNum = (num % 100) / 10;
        firstNum = (num / 1000) % 10;
        if (firstNum == lastNum) Console.WriteLine($"{num} -> Да");
        else Console.WriteLine($"{num} -> Нет");
    }
    else Console.WriteLine($"{num} -> Нет");


}

