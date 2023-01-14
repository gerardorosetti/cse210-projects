public class Entry {

    public string _prompt; // The prompt that is part of the entry.
    public string _answer; // the answer from the user.
    public string _date; // the date that the user writes the entry.

    public void Display(){ // show the entry.
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt}\n{_answer}");
    }

}