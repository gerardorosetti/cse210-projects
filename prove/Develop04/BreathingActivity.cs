public class BreathingActivity: Activity
{
    public BreathingActivity(string title, string description, int duration) : base(title,description,duration)
    {

    }
    public void DisplayBreathingCycle()
    {
        DisplayStartinMessage();
        int i = 0, duration = _duration;
        while(duration > 0)
        {
            Console.Write("\n");
            if(i%2==0)
            {
                DisplayPrompt(0);
                CountDown(4);
                duration = duration - 4;
            }
            else
            {
                DisplayPrompt(1);
                CountDown(6);
                Console.Write("\n");
                duration = duration - 6;
            }
            i++;
        }
        Record();
        DisplayEndingMessage();
    }
}