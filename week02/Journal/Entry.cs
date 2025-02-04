public class Entry
{
    DateTime data = DateTime.Now;
    
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    

    public void Display()
    {
        _date = data.ToLongDateString();
        System.Console.WriteLine($"{_date}  {_promptText}");
        System.Console.WriteLine($" - {_entryText} - ");
    }
}