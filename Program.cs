using System.Collections;


Week week = new Week();
foreach (var day in week)
{
    Console.WriteLine(day);
}

class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = 8;
    public WeekEnumerator(string[] days) => this.days = days;
    public object Current
    {
        get
        {
            //if (position == -1 || position >= days.Length) // не понял зачем эта проверка
            //    throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if (position >= 2)
        {
            position = position - 2;
            return true;
        }
        else
            return false;
    }
    public void Reset() => position = 8;
}
class Week
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
}
