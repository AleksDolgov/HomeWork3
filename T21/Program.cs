/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetNumber(string message)
{
    int result = 0;
    
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
           {
            break;
            }
           
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }
    

    return result;
}


int x1 = GetNumber("Введите координату Х1:");
int y1 = GetNumber("Введите координату У1:");
int z1 = GetNumber("Введите координату z1");
int x2 = GetNumber("Введите координату Х2:");
int y2 = GetNumber("Введите координату У2:");
int z2 = GetNumber("Введите координату z2");

double length = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine($"Расстояние между точками равняется {length}");

