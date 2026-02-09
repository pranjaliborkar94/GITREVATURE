using System;

namespace Day5_Exercise.ObjectConcepts
{
    class Student
    {
        public int Id;

        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            return s != null && Id == s.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class EqualsDemo
    {
        public static void Run()
        {
            Student s1 = new Student { Id = 1 };
            Student s2 = new Student { Id = 1 };

            Console.WriteLine(s1.Equals(s2));
        }
    }
}
