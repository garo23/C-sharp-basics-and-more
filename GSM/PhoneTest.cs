class PhoneTest
{
    public static void PhoneFactory()
    {
        Phone[] phones = new Phone[3];
        phones[0] = new Phone("Redmi9", "Xiaomi", "200$");
        phones[1] = new Phone("Iphone13", "Apple", "800$");
        phones[2] = new Phone("A52", "Samsung", "300$");

        for(int i = 0; i < phones.Length; i++)
        {
            phones[i].GetInfo();
            Console.WriteLine(" ");
        }
 }
}
