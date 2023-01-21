//I used this webpage to know how to read information from a csv in c#: https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
using System;

class Program
{
    static void Main(string[] args)
    {
        string book;
        int chapt;
        int startVerse;
        int endVerse;

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer\n");
        Console.Write("Write the name of the book: ");
        book = Console.ReadLine();

        do
        {
            Console.Write("Write the number of the chapter you want to read: ");
            chapt = int.Parse(Console.ReadLine());
            if(chapt <= 0) Console.WriteLine("\nThe chapter should be greater than 0.\n");
        }while(chapt <= 0);

        do
        {
            Console.Write("Write the number of the start verse: ");
            startVerse = int.Parse(Console.ReadLine());
            if(startVerse <= 0) Console.WriteLine("\nThe start verse should be greater than 0.\n");
        }while(startVerse<=0);

        do
        {
            Console.Write("Write the number of the end verse (write 0 if none): ");
            endVerse = int.Parse(Console.ReadLine());
            if(endVerse <= 0) Console.WriteLine("\nThe end verse should be a positive number.\n");
            else if(endVerse != 0 && endVerse < startVerse)
            {
                Console.WriteLine("\nThe end verse should be greater or equal than the start verse.\n");
                endVerse = -1;
            }
        }while(endVerse < 0);
        
        Scripture scripture;
        if(endVerse <= 0)
        {
            scripture = new Scripture(book,chapt,startVerse);
        }
        else
        {
            scripture = new Scripture(book,chapt,startVerse,endVerse);
        }
        Console.Clear();
        scripture.DisplayScripture();
    }
}