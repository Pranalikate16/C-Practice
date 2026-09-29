

public struct student
{
    private string FirstName;
    private string _lastName;

    public student()
    { }
    public student(string fn,string ln)
    {
        FirstName = fn;
        _lastName = ln;
    }

    public void Details()
    {
        Console.WriteLine($"Full Name : {FirstName} {_lastName}");
    }
}

public class B27Student : student //we cannot implement inheritance in struct
{ 

}