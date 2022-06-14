// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



   
        Console.Write("Enter person's name: "); 
        string person = Console.ReadLine(); //0
Console.Write("Enter book's name: "); 
        string book = Console.ReadLine(); //1
string form = "Authors Team";
Console.Write("Enter author's name"); 
string author = Console.ReadLine(); //2


Console.WriteLine("We are pleased to inform" +
            "you that \"{1}\" is the best Bulgarian book.{0}" +
            "The authors of the book wish you good luck,{0}!{2}",
            person, book, author);
        Console.WriteLine("Yours,");
        Console.WriteLine("  {0}", form);
    

