// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
int InputInt(string msg)
{
    System.Console.WriteLine($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check(int num)
{
    if (num <= 0)
    {
        System.Console.WriteLine("Недопустимое число. Дальнейшие действия невозможны.");
        Environment.Exit(1);
    }
}
string[] CreateArray(int len)
{
    string[] array = new string[len];
    System.Console.WriteLine("Вводите с новой строчки наборы символов для очередного элемента массива:");
    for (int i = 0; i < len; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}
void GetFinalArray (string[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    if (count == 0)
    {
        System.Console.WriteLine("Во всех элементах этого массива более трёх символов.");
    }
    else
    {
        int c = 0;
        string[] foundArray = new string[count];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <= 3)
            {
                foundArray[c] = array[j];
                c++;
            }

        }
        for (c = 0; c < count; c++) System.Console.WriteLine(foundArray[c]);
    }
}
void PrintArray(string[] anyArray, string heading)
{
    System.Console.WriteLine(heading);
    int len = anyArray.Length;
    for (int n = 0; n < len; i++)
    System.Console.WriteLine(anyArray[n]); 
}
int length = InputInt("Введите количество элементов в исходном массиве");
Check(length);
string[] arr = CreateArray(length);
GetFinalArray(arr);

