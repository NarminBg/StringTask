namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var class1= new Class1();
           int[] arr=class1.EnterArray();
           class1.Print(arr);
           int[] sqrtArr = class1.GetSqrtElements(arr);
            Console.WriteLine($"{sqrtArr}-kvadrat olan edeler");


        }
    }
}