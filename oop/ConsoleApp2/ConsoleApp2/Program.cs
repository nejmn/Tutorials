using System;

namespace ConsoleApp2
{
    /*Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
     * There will be two people of the Student type and one person of the Teacher type.

To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter
and overrides the ToString () method.

Then create two more classes that inherit from the Person class, they will be called Student and Teacher. The Student 
class has a Study method that writes by console that the student is studying. The Teacher class will have an Explain method
that writes to the console that the teacher is explaining. Remember to also create two constructors on the child classes that
call the parent constructor of the Person class.

End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.*/
    class Program
    {
        static void Main(string[] args)
        {
            int ppl = 3;
            Person[] people = new Person[ppl];

            for(int i=0;i<ppl;i++)
            {
                if(i==0)
                {
                    people[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    people[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < ppl; i++)
            {
                if (i == 0)
                {
                    ((Teacher)people[i]).Explain();

                }
                else
                {
                    ((Student)people[i]).Study();
                }
            }
            Console.ReadLine();
        }

        public class Person
        {
            public string Name { get; set; }

            public Person(string name) { Name = name; }

            public override string ToString()
            {
                return "Name:"+Name;
            }
            ~Person() { Name = " "; }
        }

        public class Teacher:Person
        {
            public Teacher(string name) : base(name) { Name = name; }

            public void Explain()
            {
                Console.WriteLine("I am explaining");
            }
        }
        public class Student : Person
        {
            public Student(string name) : base(name) { Name = name; }

            public void Study()
            {
                Console.WriteLine("I am learning");
            }
        }
    }
}
