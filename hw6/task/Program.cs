// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

System.Console.WriteLine("Введите строку");
string userInput = Console.ReadLine()!.ToLower();
Console.WriteLine(userInput);

//Задача 1: Создание строки из двумерного массива символов
public class Task1
{
    public static void Main(string[] args)
    {
        char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
        string result = CreateStringFrom2DArray(charArray);
        Console.WriteLine(result);
    }
    public static string CreateStringFrom2DArray(char[,] array)
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        }
        return result;
    }
}