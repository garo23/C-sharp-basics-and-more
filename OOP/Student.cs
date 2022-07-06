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

        public void setName(string name)
        {
            _name =name;
        }
        public void setSecName(string secondname)
        {
            _secondname = secondname;
        }
        public void setFamily(string family)
        {
            _family = family;
        }


        public void setCourse(string course)
        {
            _course = course;
        }

        public void setDiscipline(string discipline)
        {
            _discipline = discipline;
        }

        public void setEmail(string email)
        {
            _email = email;
        }

        public void setPhone(string phone)
        {
            _phone = phone;
        }

        public void setUni(string university)
        {
            _university = university;
        }
        public string getName()
        {
            return _name;
        }

        public string getFamily()
        {
            return _family;
        }

        public string getSecName()
        {
            return _secondname;
        }

        public string getCourse()
        {
            return _course;
        }

        public string getDiscipline()
        {
            return _discipline;
        }

        public string getUniversity()
        {
            return _university;
        }
        public string getEmail()
        {
            return _email;
        }

        public string getPhone()
        {
            return _phone;
        }
       
        public void getInfo()
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




