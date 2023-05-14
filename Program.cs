// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
int InputInt(string msg)
{
    System.Console.WriteLine($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
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
void GetFinalArray(string[] array)
{
    int[] indexes = new int[array.Length];
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            indexes[count] = i;
            count += 1;
        }

    }
    if (count == 0)
    {
        System.Console.WriteLine("Во всех элементах этого массива более трёх символов.");
    }
    else
    {
        System.Console.WriteLine("Вот элементы, в которых не более трёх символов:");
        for (int c = 0; c < count; c++)
        System.Console.WriteLine(array[indexes[c]]);
    }
}
int length = InputInt("Введите количество строк в исходном массиве");
string[] arr = CreateArray(length);
GetFinalArray(arr);

