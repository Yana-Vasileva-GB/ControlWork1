Console.Clear();
Console.WriteLine($"Добрый день! Я помогу Вам найти строки, длина которых не превышает 3 символа. \nСколько строк Вы хотите проверить?");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
Console.WriteLine("Отлично! Теперь введите Ваши строки:");
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
}

string[] result = new string[array.Length];
void ResultArray(string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[count] = array[i];
        count++;
        }   
        }
}

void PrintArray(string[] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine("]");
}

PrintArray(array);
ResultArray(array, result);
PrintArray(result);
