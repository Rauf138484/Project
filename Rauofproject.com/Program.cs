using System.Linq.Expressions;

Console.Write("Enter the array lenghts: ");
int n= int.Parse(Console.ReadLine());
int[] myArray = new int[n];
Console.WriteLine("Enter the elements of the array: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Element {0}:  " ,i+1);
    myArray[i] = int.Parse(Console.ReadLine());         
}
Console.WriteLine("The elements are: ");
foreach (int i in myArray)
{
    Console.Write(i + " ");
}
