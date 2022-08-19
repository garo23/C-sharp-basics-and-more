using Bridge.Vehicle;

Veichle AudiA4 = new Car(new Produce(),new Assemble());
Bike Baccini = new Bike(new Produce(), new Assemble());

AudiA4.Manufacture();
Console.WriteLine("----------------------");
Baccini.Manufacture();