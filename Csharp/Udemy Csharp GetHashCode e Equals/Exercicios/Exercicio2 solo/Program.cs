using Exercicio2_solo.Entities;

HashSet<Student> A, B, C, NumberOfStudents;
A  = new HashSet<Student>();
B  = new HashSet<Student>();
C  = new HashSet<Student>();

Console.Write("How many students for course A? ");
int StudentNumber = Read();
StudentsCount(StudentNumber, A);

Console.Write("How many students for course B? ");
StudentNumber = Read();
StudentsCount(StudentNumber, B);

Console.Write("How many students for course C? ");
StudentNumber = Read();
StudentsCount(StudentNumber, C);

NumberOfStudents = new HashSet<Student>(A);
NumberOfStudents.UnionWith(B);
NumberOfStudents.UnionWith(C);

Console.WriteLine("Total students: " + NumberOfStudents.Count);

void StudentsCount(int n, HashSet<Student> x)
{
    for (int i = 0; i < n ; i++)
    {
        int student = int.Parse(Console.ReadLine()!);
        x.Add(new Student(student));
    }
}

int Read()
{
    return int.Parse(Console.ReadLine()!);
}