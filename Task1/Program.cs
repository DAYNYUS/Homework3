//Напишите прогамму, которая принимает на вход пятизначное число и проверяет,
//является ли оно полиндромом (14212 -> нет; 23432 -> да; 12821 -> да)

Console.Write("Введите пятизначное число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  

bool IsItPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsItPalindrome()) Console.WriteLine("да");
else Console.WriteLine("нет");
Console.WriteLine();
