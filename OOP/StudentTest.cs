using OOP;

class StudentTest
{
    public Student _s1;
    public Student _s2;
    public Student _s3;

    Student s1 = new Student("gero", "gerov", "gerovski","KST","Nummerische Verfahren","Technische Univesitat","gero.gerovski@gmail.com","0896574388");
    Student s2 = new Student("ivan", "ivanov", "ivanov", "IT", "WINF", "Technische Uni", "ivanivanov@gmail.com", "0896754332");
    Student s3 = new Student("georgi", "gerogiev", "georgiev", "IT", "WINF", "Technische Uni", "gerogigeorgiev@gmail.com", "0896754332");
    public void Factory(Student s1,Student s2, Student s3)
    {
        _s1 = s1;
        _s2 = s2;
        _s3 = s3;

    }

}