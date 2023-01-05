using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in percentage? ");
        string ans = Console.ReadLine();
        int grade = int.Parse(ans);
        char result;
        char sign;

        if(ans[ans.Length-1] >= 55 && ans[ans.Length-1] <= 57 && ans[0] != 57 && ans[0] > 53){
            sign = '+';
        }else if(ans[ans.Length-1] >= 48 && ans[ans.Length-1] < 51 && ans[0] > 53){
            sign = '-';
        }else{
            sign = ' ';
        }

        if(grade >= 90){
            result = 'A';
        }else if(grade >= 80){
            result = 'B';
        }else if(grade >= 70){
            result = 'C';
        }else if(grade >= 60){
            result = 'D';
        }else{
            result = 'F';
        }

        Console.WriteLine($"Your grade is: {result}{sign}");

        if (grade >= 70){
            Console.WriteLine("Congratulations, You passed!");
        }
        else{
            Console.WriteLine("Better luck next time");
        }
    }
}