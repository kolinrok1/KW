void ArrRandom (string [] array)
{
    for ( int i=0; i<array.Length; i++)
    {
        Console.Write("Введите элемент "+ i +" :");
        array [i]= Console.ReadLine();
    }
}

void PrintArray (string [] array)
{
    for (int i=0; i<array.Length;i++)
    {
    Console.Write(array[i]+ " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("Введите длинну массива");
int size =Convert.ToInt32(Console.ReadLine());
string [] array = new string[size];
ArrRandom(array);
PrintArray(array);