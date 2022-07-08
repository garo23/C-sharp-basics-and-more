class Phone 
{

    private string _Modelle;
    private string _Hersteller;
    private string _Preis;
    private string _Besitzer;
    private string _Batterie;
    private string _Display;

    private string _NokiaN95;

    public Phone(string Modelle, string Hersteller, string Preis)
    {
        _Modelle = Modelle;
        _Hersteller = Hersteller;   
        _Preis = Preis; 
    }
   
    public string GetModelle()
    {
        return _Modelle;
    }

    public string GetHersteller()
    {
        return _Hersteller;
    }

    public string GetPreis()
    {
        return _Preis;
    }

    public void GetInfo()
    {
        Console.WriteLine("Modelle: " + _Modelle);
        Console.WriteLine("Hersteller: " + _Hersteller);
        Console.WriteLine("Preis: " + _Preis);
    }

    public string GetGsm(string Gsm)
    {
        return Gsm;
    }

    public static void DeleteAllCalls(List<Call> calls)
    {
        calls.Clear();

    }

    public void AddCall(DateTime date, DateTime time, TimeSpan callDuration)
    {
        List<Call> list = new List<Call>();
        list.Add(new Call(date, time, callDuration));
    }
  


}

