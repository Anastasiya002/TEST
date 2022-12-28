Console.Clear();
string[] array1 = {"hsfsdfds", "Sam", "328", "njnjj", "/(0)"};
string[] array2 = new string[array1.Length];
Array2(array1, array2);
void Array2(string[] array1, string[] array2)
{
int count = 0;
for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        } 
    }
}
void PrintArray(string[] array)
{   
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write($"] ");
}
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);