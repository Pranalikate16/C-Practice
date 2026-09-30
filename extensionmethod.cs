


public sealed class student 
{
    public void PrintA()
    {
        Console.WriteLine("student  PrintA() Method");    
    }

    //public void PrintB()
    //{
    //    Console.WriteLine("student PrintB() method");
    //}


}

//public class NewStudent : student
//{
//    public void PrintB()
//    {
//        Console.WriteLine("Student PrintB() Method");
//    }
//}

public static class StudentHelper
{
    public static void PrintB(this student s )
    {
        Console.WriteLine("Extension method for student");
    }

}