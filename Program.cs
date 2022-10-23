//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool NumPalindrome(int num)
{
    bool result = false;
    int i = 10;
    int count = 1;
    while (num >= i)
    {
        i = i * 10;
        count = count + 1;
    }
    int middle = 0;
    while (middle < count / 2)
    {
        int a = count - middle;
        int b = middle + 1;
        int c = count - b;
        int homeSign = num % Convert.ToInt32(Math.Pow(10,a)) / Convert.ToInt32(Math.Pow(10,c));
        int endSign = num % Convert.ToInt32(Math.Pow(10,b)) / Convert.ToInt32(Math.Pow(10,middle));
        if (homeSign == endSign)
        {
            result = true;
            middle = middle + 1;
        }
        else result = false;
        break;
    }  
    return result;
}


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumPalindrome(number));
