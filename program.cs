using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("kevin grey", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("ponari", 25, 12345, "pemrogaman");
            teacher.GetNameAndAge();

            Student student = new Student("Hizkia", 17, 2678, "alfandiloelan@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
