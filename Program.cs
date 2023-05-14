
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
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
        array[i] = String.Empty + Console.ReadLine();
    }
    return array;
}
void GetFinalArray (string[] array)
{
    int len = array.Length;
    string[] someArray = new string[len];
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            someArray[count] = array[i];
            count += 1;
        }
    }
    if (count == 0)
    {
        System.Console.WriteLine("Во всех элементах этого массива более трёх символов.");
    }
    else
    {
        string[] foundArray = new string[count];
        System.Console.WriteLine("Выбраны элементы не более чем из трёх символов. Вот массив сз них:");
        for (int c = 0; c < count; c++) 
        {
            foundArray[c] = someArray[c];
            System.Console.Write(foundArray[c] + "\t");
        }
    }
}
int length = InputInt("Введите количество элементов в исходном массиве");
Check(length);
string[] arr = CreateArray(length);
GetFinalArray(arr);

