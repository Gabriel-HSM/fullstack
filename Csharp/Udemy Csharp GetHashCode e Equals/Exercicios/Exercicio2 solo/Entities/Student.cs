namespace Exercicio2_solo.Entities
{
    public class Student
    {
        public int Code { get; set; }

        public Student(int code)
        {
            Code = code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            return false;

            Student other = (Student)obj;
            return Code.Equals(other.Code);
        }
    }
}