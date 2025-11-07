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
        public static List<Student> ViewAndAvarage()
        {

            List<Student> result = DataStudents.ListTExercise();
            //foreach (var s in student)
            //{
            //    Console.WriteLine(s.Name + " - " + s.Grade);
            //}
            return result;
        }
    }

}

