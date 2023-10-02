
using System;
public class oop2
{
     
    public static void Main(string[] args)
    {
        int[][] jagged1 = new int[][]
        {
            new int [] {2,3,4},
            new int [] {1,5,6},
            new int [] {10,12,15}
        };
        int[][] jagged2 = new int[][]
        {
            new int [] {50,30,20},
            new int [] {200,300,9}
        };
        int[][] result = jagged1.Concat(jagged2).ToArray();
        /*Ans for 4--> merged array*/
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result[i].Length; j++)
            {
                Console.Write(result[i][j] + " ");
            }
            Console.WriteLine();
        }
        
        /*Ans for 3--> finding values position*/
        //Console.WriteLine("Enter input: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //bool found = false;
        //for (int i = 0; i < jagged1.Length; i++)
        //{
        //    for (int j = 0; j < jagged1[i].Length; j++)
        //    {
        //        if (jagged1[i][j]==num)
        //        {
        //            Console.WriteLine("The given value's position is: " + i + " " + j);
        //            found = true;
        //            break;
        //        }
        //    }
        //    Console.WriteLine();
        //}
        //if (!found)
        //    Console.WriteLine("Not Found");

        Console.ReadLine();
    }
}





