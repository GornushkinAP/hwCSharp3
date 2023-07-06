// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом не используя функцию IsPalindrome
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int numbrs = Convert.ToInt32(Console.ReadLine());


// string? input = Console.ReadLine();
// bool result = int.TryParse(input, out var number);
// if (result != true)
// {
//     Console.WriteLine("Вводите обязательно цифры!");
// }
// else 
// {
//     // Console.WriteLine("Вы ввели цифры!");

int[] digits = new int[5];
int temp = numbrs;

for (int i = 0; i < 5; i++)
{
    digits[i] = temp % 10;
    temp /=10;
}

if (digits[0] == digits[4] & digits[1] == digits[3])
{
    Console.WriteLine("Число является полиндромом. Досвидания.");
}
else
{
   Console.WriteLine("Число не является полиндромом. Попробуйте снова."); 
}
