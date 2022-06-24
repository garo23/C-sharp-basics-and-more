namespace CodesTests
{
    public class Class1test : Dog
    {
        public Class1test(string name) : base(name)
        {
        }

        static void main(String[] args)
        {

            Dog dog = new Dog("Lassie");
            Console.WriteLine(dog);
            dog.dogBark();



        }
    }
}
