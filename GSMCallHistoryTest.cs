class GSMCallHistoryTest
{
    public static void GSMCallHistoryTestMethod()
    {
        Phone myPhone = new Phone("Iphone6", "Apple", "400$");
         Random rnd = new Random();

        List<DateTime> myDates = new List<DateTime>() {new DateTime (2022,06,23), new DateTime(2022,06,24),
        new DateTime (2022,06,25), new DateTime(2022,06,26) };

        List<DateTime> myTimes = new List<DateTime>() { new DateTime (2022,06,23,15,34,25), new DateTime(2022,06,24,10,26,14),
        new DateTime (2022,06,25,07,55,37), new DateTime(2022,06,26,20,01,01) };

        List<TimeSpan> myDurations = new List<TimeSpan> { new TimeSpan(0,20,46),new TimeSpan(0,34,26),new TimeSpan(0,07,57),
        new TimeSpan(00,05,42)};

        int numOfCalls = rnd.Next(1, 100);
        for (int i = 0; i < numOfCalls; i++)
        {
            myPhone.AddCall(myDates[rnd.Next(0, 4)], myTimes[rnd.Next(0, 4)], myDurations[rnd.Next(0, 4)]);
        }
        

    }


}