public class Todolist
{
    public string? Name
    { get; set; }
    public bool IsDone { get; set; } = false;
    public bool IsEdit{get;set;}=false;
    public Todolist(string n)
    {
        Name = n;
    }
}
