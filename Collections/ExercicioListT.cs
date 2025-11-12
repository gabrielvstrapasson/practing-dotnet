using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes.Collections
{

    public class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }

    public class DataStudents
    {
        public static List<Student> ListTExercise()
        {

            List<Student> students = new()
            {
                new Student { Name = "Maria", Grade = 8.75 },
                new Student { Name = "Manoel", Grade = 6.95 },
                new Student { Name = "Amanda", Grade = 7.25 },
                new Student { Name = "Carlos", Grade = 6.55 },
                new Student { Name = "Jaime", Grade = 8.50 },
                new Student { Name = "Debora", Grade = 5.95 },
                new Student { Name = "Alicia", Grade = 9.25 },
                new Student { Name = "Sandra", Grade = 5.55 },
                new Student { Name = "Marta", Grade = 7.85 },
                new Student { Name = "Sueli", Grade = 9.15 }
            };

            return students;


            /*
            string[,] student = new string[,]
            {
                {"Maria", "8.75"},
                {"Manoel", "6.95" }
            };
         
            for (int i = 0; i < student.GetLength(0); i++)
            {

                for (int j = 0; j < student.GetLength(1); ++j)
                { 
                    Console.Write(student[i, j] + " ");
                    if (j > 0)
                        Console.WriteLine();
                }
            }
            */
        }

    }

    public class ExercicioListT
    {



        public static void PrintInformationsAboutStudent()
        {
            Console.WriteLine("-------------------------------------");
            List<Student> resultStudents = ViewAndAverage();
            foreach (var s in resultStudents)
            {
                Console.WriteLine($"Student: {s.Name} - Grade: {s.Grade}");
            }
            AverageGrade(ViewAndAverage());

            resultStudents.Add(new Student { Name = "Bia", Grade = 7.75 });
            resultStudents.Add(new Student { Name = "Mario", Grade = 8.95 });
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\nAfter adding two new students:\n");

            foreach (var s in resultStudents)
            {
                Console.WriteLine($"Student: {s.Name} - Grade: {s.Grade}");
            }


            var findItem = resultStudents.Find(resultStudents => resultStudents.Name == "Amanda");
            Console.WriteLine("-------------------------------------");
            if (findItem == null)
                Console.WriteLine("Student not found.");

            resultStudents.Remove(findItem);

            Console.WriteLine("\nAfter removing Amanda:\n");

            foreach (var s in resultStudents)
            {
                Console.WriteLine($"Student: {s.Name} - Grade: {s.Grade}");
            }


            resultStudents.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Order students");

            foreach (var s in resultStudents)
            {
                Console.WriteLine($"Student: {s.Name} - Grade: {s.Grade}");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Students with grade higher than 8: ");

            var highGrades = resultStudents.Where(s => s.Grade > 8);

            foreach (var s in highGrades)
            {
                Console.WriteLine($"Student: {s.Name} - Grade: {s.Grade}");
            }
        }
        public static List<Student> ViewAndAverage()
        {

            List<Student> result = DataStudents.ListTExercise();
            return result;
        }

        public static double AverageGrade(List<Student> students)
        {
            double sum = 0;

            foreach (var s in students)
            {
                sum += s.Grade;
            }

            var Average = sum / students.Count;

            Console.WriteLine($"The average grade of the class is: {Average:N2}");

            return Average;
        }

    }

}

