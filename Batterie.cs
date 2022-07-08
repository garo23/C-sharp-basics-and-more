class Batterie
{
    private string _Modelle;
    private string _IdleTime;
    private int _Stunden;
    private string _BatteryType;

    public Batterie(string Modelle, string IdleTime, int Stunden)
    {
        _Modelle = Modelle;
        _IdleTime = IdleTime;
        _Stunden = Stunden;
    }
     
    public Batterie(string BatteryType)
    {
         _BatteryType = BatteryType;
    }

}