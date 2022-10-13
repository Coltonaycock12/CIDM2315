namespace Week7HW6;
class Program
{
    static void Main(string[] args)
    {
        //Create a new professor object
    Professor p1 = new Professor();
    p1.profName = "Alice";
    p1.classTeach = "Java";
    p1.salary = 9000;

    Professor p2 = new Professor();
    p2.profName = "Bob";
    p2.classTeach = "Math";
    p2.salary = 8000;

    Student s1 = new Student();
    s1.studentName = "Lisa";
    s1.classEnroll = "Java";
    s1.studentGrade = 90; 

    Student s2 = new Student();
    s2.studentName = "Tom";
    s2.classEnroll = "Math";
    s2.studentGrade = 80;



    p1.PrintProfessorInfo();
    p2.PrintProfessorInfo();
    s1.PrintStudentInfo();
    s2.PrintStudentInfo();

    Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {p1.salary - p2.salary}");
    Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {s1.studentGrade + s2.studentGrade}");


    }
}

class Professor
{
    public string profName;
    public string classTeach;
    public double salary {get;set;}

    public void PrintProfessorInfo(){
        System.Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary} ");
    }


}


class Student{
    //The attributes
    public string studentName;
    public string classEnroll;

    public double studentGrade{get;set;}




    //The behaviors
    public void PrintStudentInfo(){
        System.Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }
}
