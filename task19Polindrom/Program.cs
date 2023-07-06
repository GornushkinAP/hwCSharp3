// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("И Снова Здравствуйте! Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (IsPalindrome(number))
    {
     Console.WriteLine("Данное число является палиндромом. Всего доброго. ");
    }
    else
    {
     Console.WriteLine("Данное число не является палиндромом. Всего доброго. ");
    }

static bool IsPalindrome(int number)
{
    string numberString = number.ToString();
    int length = numberString.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (numberString[i] != numberString[length - i - 1])
        {
            return false;
        }
    }

    return true;
}