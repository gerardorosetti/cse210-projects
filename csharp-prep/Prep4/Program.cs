using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int aux;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter Number: ");
            aux = int.Parse(Console.ReadLine());
            nums.Add(aux);
        }while(aux != 0);
        nums.RemoveAt(nums.Count - 1);

        int sum = 0, largest = nums[0], smallest = Int32.MaxValue;

        foreach(int num in nums){
            sum += num;
            if(largest<num) largest = num;
            if(smallest>num && num > 0) smallest = num;
        }

        Console.WriteLine("The sum is: {0}\nThe average is: {1}\nThe largest number is: {2}\nThe smallest positive number is: {3}\nThe sorted list is:", sum, ((float)sum)/nums.Count, largest, smallest);
        
        nums.Sort();

        foreach(int num in nums){
            Console.WriteLine(num);
        }

    }
}