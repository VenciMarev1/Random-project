using System.Security.Claims;

namespace random_project;

class Grade
{
    public int _grade { set; get; }
    public string _class { set; get; }

    public Grade(int Grade, string Class)
    {
        this._class = Class;
        this._grade = Grade;
    }
    public Grade()
    {
        this._class = null;
        this._grade = 2;
    }

}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Grade[] grades = GetGradeForEveryClass(new Grade[n]);
        Console.ReadLine();
    }

    static public Grade[] GetGradeForEveryClass(Grade[] _grade)
    {

        Console.WriteLine("Enter the class and the grade for the class: ");
        for(int i = 0; i < _grade.Length; i ++)
        {
            Console.Write("class" + (i + 1) + ": ");
            string _class = Console.ReadLine();

            Console.WriteLine();
            Console.Write("grade: ");
            int grade = int.Parse(Console.ReadLine());

            _grade[i] = new Grade(grade, _class);
        }

        return new Grade[3];
    }
}

