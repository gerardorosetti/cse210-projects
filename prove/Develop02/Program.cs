using System;
// I used this webpage to know about how to handle the FileNotFoundException: https://rollbar.com/blog/csharp-filenotfoundexception/#:~:text=One%20of%20the%20most%20commonly,mismatch%20in%20the%20file%20name.
// I used this webpage to know how to clear a list in c#: https://www.techiedelight.com/es/delete-all-items-from-a-list-in-csharp/#:~:text=Una%20soluci%C3%B3n%20simple%20y%20directa,Clear()%20m%C3%A9todo. 

// For Exceeding Requirements, was added the option to add and delete new prompts to the journal, this changes ara saved in a file called prompts.txt
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        do{
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Write new Prompt\n6. Delete a Prompt\n7. Quit\nWhat would you like to do?: ");
            int choise = int.Parse(Console.ReadLine());
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            switch(choise){
                case 1:
                    myJournal.Write();
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    myJournal.SaveToFile();
                    break;
                case 5:
                    myPrompts.Write();
                    break;
                case 6:
                    myPrompts.Delete();
                    break;
                case 7:
                    flag = false;
                    Console.WriteLine("\nHope to see you soon :D.\n");
                    break;
                default:
                    Console.WriteLine("\nNo option number has been chosen, please try again.");
                    break;
            }
        }while(flag);
    }
}