// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинной меньше либо равно 3

string[] array = new string[4];
Console.WriteLine("введите значение 1");
array[0] = Console.ReadLine();
Console.WriteLine("введите значение 2");
array[1] = Console.ReadLine();
Console.WriteLine("введите значение 3");
array[2] = Console.ReadLine();
Console.WriteLine("введите значение 4");
array[3] = Console.ReadLine();
PrintArray(array);
Console.WriteLine();
string[] newArray = NewArray(array);
PrintArray(newArray);

void PrintArray(string[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write("]");
}

string[] NewArray(string[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
      if (arr[i].Length <= 3)
      count=count+1;
}
   int j = 0;
  string[] newArr = new string[count];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      newArr[j] = arr[i];
      j++;
  }
  
}
return newArr;
}
