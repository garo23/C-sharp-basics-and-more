using System;
class Call 
{
    private DateTime _Data;
    private DateTime _StartCall;
    TimeSpan _CallLength;

    private string _CallPrise;
    
    public DateTime Data
    {
        
        get { return _Data; }
    }

    public DateTime StartCall
    {
        get { return _StartCall; }
    }

    public TimeSpan CallLength
    {
        get { return _CallLength; }
        set
        {
            if (value.Minutes <= 0) throw new ArgumentException("Invalid call duration!");
            this.CallLength = value;
        }
    }

    public Call(DateTime data, DateTime startcall, TimeSpan calllength)
    {
        _Data = data;
        _StartCall = startcall;
        _CallLength = calllength;
    }
    public List<Call> CallHistory()
    {
        List<Call> list = new List<Call>();
        Call[] arr = new Call[10]; 
        for (int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);
        }
        return list;
       
    }
    public void SumCalls()
    {
        int CallPrise = int.Parse(Console.ReadLine());
        List<Call> l = CallHistory();
        int Num_Of_Calls = l.Count;
        int fee = Num_Of_Calls * CallPrise;
        

    }

}
    
    
