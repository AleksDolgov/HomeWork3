/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int GetDigit(string message)
{
    int result = 0;
    string errorMessage = "Недопустимое значение. Введите цифру от 0 до 9";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
           {
            if(result<0 || result>9)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
            {
                break;
            }
           }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}

int digit1 = GetDigit("Введите первую цифру пятизначного числа");
int digit2 = GetDigit("Введите вторую цифру пятизначного числа");
int digit3 = GetDigit("Введите третью цифру пятизначного числа");
int digit4 = GetDigit("Введите четвертую цифру пятизначного числа");
int digit5 = GetDigit("Введите пятую цифру пятизначного числа");

int[] array = { 0, 0, 0, 0, 0 };
array[0] = digit1;
array[1] = digit2;
array[2] = digit3;
array[3] = digit4;
array[4] = digit5;

if (array[0] == array[4] || array[1] == array[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является плиндромом");
}