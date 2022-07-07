namespace OOP
{
    class Student
    {
        private string _name;
        private string _secondname;
        private string _family;
        private string _course;
        private string _discipline;
        private string _university;
        private string _email;
        private string _phone;
        private static int _count;

        public Student(string name, string secondname, string family, string course, string discipline, string university, string email, string phone)
        {
            _name = name;
            _secondname = secondname;
            _family = family;
            _course = course;
            _discipline = discipline;
            _university = university;
            _email = email;
            _phone = phone;

        }
     
        public string Name
        {
            get { return _name; }
        }

       public string SecondName
        {
            get { return _secondname; }
        }

        public string Family
        {
            get { return _family; }
        }

        public string Course
        {
            get { return _course; }
        }

        public string Discipline
        {
            get { return _discipline; }
        }

        public string University
        {
            get { return _university; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Phone
        {
            get { return _phone; }
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Second name: " + _secondname);
            Console.WriteLine("Family: " + _family);
            Console.WriteLine("Course: " + _course);
            Console.WriteLine("Discipline: " + _discipline);
            Console.WriteLine("Universitat: " + _university);
            Console.WriteLine("Email: " + _email);
            Console.WriteLine("Phone" + _phone);
          
        }
    }

}




