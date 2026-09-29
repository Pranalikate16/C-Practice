
public record student
{
    public string FirstName;
    public string LastName;

    public student(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }

    public void Details()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}")}
}

//public record student(string FirstName, string Lastname)
//{
//    public student()
//    {
//    }
//    public void Details()
//    {
//        Console.WriteLine($"fullname : {FirstName} {Lastname}");

//    }
//}

public record B27Student : student
{
    public B27Student() : base("", "")
    { 
    }
}