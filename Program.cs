void ArrFill (string [] array)
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
int count = 0;
ArrFill(array);
Console.WriteLine();
Console.Write("Ваш массив: ");
PrintArray(array);
string [] arraySecond = new string [size];
for (int i=0 ; i<array.Length;i++) 
{
    if (array[i].Length<= 3) 
    {
        arraySecond[count]= array[i];
        count++;
    }
}
Console.WriteLine();
Console.Write("Итоговый массив: ");
PrintArray(arraySecond);
