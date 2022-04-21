
namespace MyFirstApplication;

internal struct Employee
{
    /*
     Change the type from class to struct. Change the name of the struct from
Exercise7 to Employee. The filename should not be changed. Create 2
struct variables. The first one will be of type int and be named _id. The
second variable should be of type string and be named _name. Create a
constructor that takes 2 arguments, with the first being an int and the
second a string. The struct variables should be assigned to the constructor
parameters. Create properties for these 2 variables.
     */
    private readonly int _id;
    private readonly string _name;

    public int EmployeeId
    {
        get { return _id; }
    }

    public string EmployeeName
    {
        get { return _name; }
    }
    public Employee(int employeeId, string employeeName)
    {
        _id = employeeId;
        _name = employeeName;
    }
}