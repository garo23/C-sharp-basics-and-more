class Book
{
    private string _Title;
    private string _Publishers;    
    private string _Author;
    private int _Year;
    private string _ISBN;

    public Book(string title, string publishers, string author, int year, string iSBN)
    {
        _Title = title;
        _Publishers = publishers;
        _Author = author;
        _Year = year;
        _ISBN = iSBN;
    }
    public string Title { get { return _Title; } }
    public string Publishers { get { return _Publishers; } }
    public string Author { get { return _Author; } }  
    public int Year { get { return _Year; } } 
    
    public string ISBN { get { return _ISBN; } }    
        
}