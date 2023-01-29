using System;
using System.ComponentModel;

class Program
{
    public void Input()
    {
        Console.WriteLine("Chose : Add, Subtract, Multiply, or Divide");
        string chose = Console.ReadLine();

        Console.WriteLine("Enter first num");
        int dec = int.Parse(Console.ReadLine());
        string binar = Convert.ToString(dec, 2);

        Console.WriteLine("Enter second num");
        int dec1 = int.Parse(Console.ReadLine());
        string binar1 = Convert.ToString(dec1, 2);
        Console.WriteLine(binar);
        Console.WriteLine(binar1);
        
       int a = Convert.ToInt32(binar, 2);
        int b = Convert.ToInt32(binar1, 2);
        if (chose=="Add")
        {
            Add(a,b);
        }
        else if (chose== "Subtract")
        {
            Subtract(a, b);
        }
        else if (chose== "Multiply")
        {
            Multiply(a, b);
        }
        else if (chose == "Divide")
        {
            Divide(a, b);
        }

    }
    public void Add(int a, int b)
    {
        
        int sum = 0;
        sum = a + b;
        Console.WriteLine("\nDecimal: {0}", sum + "\nBinary :" + Convert.ToString(sum, 2));
    }
    public void Multiply(int a, int b)
    {
        int sum = 0;
        sum = a * b;
        Console.WriteLine("\nDecimal: {0}", sum + "\nBinary :" + Convert.ToString(sum, 2));
    }
    public void Subtract(int a, int b)
    {
        int sum = 0;
        sum = a - b;
        Console.WriteLine("\nDecimal: {0}", sum + "\nBinary :" + Convert.ToString(sum, 2));
    }
    public void Divide(int a, int b)
    {
        int sum = 0;
        sum = a/b;
        Console.WriteLine("\nDecimal: {0}", sum + "\nBinary :" + Convert.ToString(sum, 2));
    }
    public static void Main(string[] args)
    {
        //Дълго решение  //dec to binary
       /*   int i,n;
          int[] arr = new int[10];// arr=10: {1,2,3,4,5,..10} arr[i] arr[3] = 4
          Console.WriteLine("Enter number");
          n = int.Parse(Console.ReadLine());
          for (i = 0; n>0; i++)
          {
              arr[i]=n % 2;
              n= n / 2;
          }//110001 -> 100011
          Console.WriteLine("Binary record");
          for (i = i-1; i>=0; i--)
          {
              Console.Write(arr[i]);
          }
*/
        Program program = new Program();
        program.Input();
        




         //dec to binary
          int dec = int.Parse(Console.ReadLine());
          string binar = Convert.ToString(dec,2);
          Console.WriteLine(binar);
          Console.WriteLine();
          //binary to dec 
          string binary = Console.ReadLine();
          var result = Convert.ToInt32(binary, 2);
          Console.WriteLine(result);
          //dec to hex
          int dec1 = int.Parse(Console.ReadLine());
          string hex = Convert.ToInt16(dec1).ToString("X");
          Console.WriteLine(hex);
         //hex to dec
          string hex1 = Console.ReadLine();//F
          int res = Convert.ToInt32(hex1,16); //15
          Console.WriteLine(res);
          // binary to hex
          string bin = Console.ReadLine();
          var result1= Convert.ToInt32(bin,2).ToString("X");
          Console.WriteLine(result1);



    }
}