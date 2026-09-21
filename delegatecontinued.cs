
public class Employee
{ 
public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Experience { get; set; }


}

public class Company
{ 
public string Name { get; set; }
    private Employee[] _employees;

    public Company(Employee[] employees)
    {
        _employees = employees;

    }

    public void AllEmployees()
    {
        Console.WriteLine($"Company Name : {Name}");
        if (_employees != null && _employees.Length > 0)
        {
            foreach (Employee emp in _employees)
            {
                Console.WriteLine($"Id {emp.Id} name {emp.Name} gender {emp.Gender} experience {emp.Experience}");
            }
        }
        else
        {
            Console.WriteLine("No Employee Found In This Company");
        }
    }

    public void PromoteEmployees()
    {
        foreach (Employee emp in _employees)
        {
            if (emp.Experience >= 3)
            {
                Console.WriteLine($"{emp.Name} is promoted");
            }
        }
    }

}