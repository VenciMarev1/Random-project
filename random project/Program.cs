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


}

class Program
{
    static void Main(string[] args)
    {

    }

    public Grade[] GetGradeForEveryClass(Grade[] _grade)
    {
        Console.WriteLine("Enter the class and the grade for the class: ");
        for(int i = 0; i < _grade.Length; i ++)
        {
            Console.Write("class" + (i + 1) + ": ");
            _grade[i]._class = Console.ReadLine();
            Console.WriteLine();
            Console.Write("grade: ");
            _grade[i]._grade = int.Parse(Console.ReadLine());
        }



        return new Grade[3];
    }
}

