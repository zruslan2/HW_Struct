using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Students
{
    public class App1
    {
        List<Student> s = new List<Student>();
        Student student1 = new Student()
        {
            StudentName = "student1",
            Group = 2,
            Mark = 10,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student2 = new Student()
        {
            StudentName = "student2",
            Group = 2,
            Mark = 4,
            FamilyIncome = 1000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Female,
            StudyType = studyType.Ochnoe
        };
        Student student3 = new Student()
        {
            StudentName = "student3",
            Group = 3,
            Mark = 4,
            FamilyIncome = 5000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Zaochnoe
        };
        Student student4 = new Student()
        {
            StudentName = "student4",
            Group = 3,
            Mark = 6,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.NotFull,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student5 = new Student()
        {
            StudentName = "student5",
            Group = 2,
            Mark = 3,
            FamilyIncome = 1000,
            StudentFamily = studentFamily.NotFull,
            Gender = gender.Female,
            StudyType = studyType.Ochnoe
        };
        Student student6 = new Student()
        {
            StudentName = "student6",
            Group = 5,
            Mark = 7,
            FamilyIncome = 1500,
            StudentFamily = studentFamily.NotFull,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student7 = new Student()
        {
            StudentName = "student7",
            Group = 2,
            Mark = 8,
            FamilyIncome = 1000,
            StudentFamily = studentFamily.NotFull,
            Gender = gender.Female,
            StudyType = studyType.Ochnoe
        };
        Student student8 = new Student()
        {
            StudentName = "student8",
            Group = 2,
            Mark = 5,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student9 = new Student()
        {
            StudentName = "student9",
            Group = 2,
            Mark = 5,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student10 = new Student()
        {
            StudentName = "student10",
            Group = 2,
            Mark = 4,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        Student student11 = new Student()
        {
            StudentName = "student11",
            Group = 2,
            Mark = 10,
            FamilyIncome = 2000,
            StudentFamily = studentFamily.Full,
            Gender = gender.Male,
            StudyType = studyType.Ochnoe
        };
        public void Print()
        {
            s.Add(student1);
            s.Add(student2);
            s.Add(student3);
            s.Add(student4);
            s.Add(student5);
            s.Add(student6);
            s.Add(student7);
            s.Add(student8);
            s.Add(student9);
            s.Add(student10);
            s.Add(student11);
            Console.WriteLine("Вывести: \n 1. Всех студентов, \n 2. Студентов, у которых не полная семья, \n 3. Студенты, с баллом выше 5, \n 4. Студенты, с баллом ниже 5, \n 5. 3 студентов, с самым низким доходом семьи, а так у которых неполноценная семья ");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                foreach (Student item in s)
                {
                    Console.WriteLine("Имя: {0}\nГруппа: {1}\nОценка: {2}\nДоход семьи: {3}\nСемья: {4}\nПол: {5}\nВид учебы: {6}", item.StudentName, item.Group, item.Mark, item.FamilyIncome, item.StudentFamily, item.Gender, item.StudyType);
                    Console.WriteLine("--------------------");
                }
            }
            else if (ch == 2)
            {
                foreach (Student item in s)
                {
                    if (item.StudentFamily == studentFamily.NotFull)
                    {
                        Console.WriteLine("Имя: {0}\nГруппа: {1}\nОценка: {2}\nДоход семьи: {3}\nСемья: {4}\nПол: {5}\nВид учебы: {6}", item.StudentName, item.Group, item.Mark, item.FamilyIncome, item.StudentFamily, item.Gender, item.StudyType);
                        Console.WriteLine("--------------------");
                    }
                }
            }
            else if (ch == 3)
            {
                List<Student> newS = s.FindAll(s => s.Mark > 5);
                foreach (Student item in newS)
                {
                    Console.WriteLine("Имя: {0}\nГруппа: {1}\nОценка: {2}\nДоход семьи: {3}\nСемья: {4}\nПол: {5}\nВид учебы: {6}", item.StudentName, item.Group, item.Mark, item.FamilyIncome, item.StudentFamily, item.Gender, item.StudyType);
                    Console.WriteLine("--------------------");
                }
            }
            else if (ch == 4)
            {
                List<Student> newS = s.FindAll(s => s.Mark < 5);
                foreach (Student item in newS)
                {
                    Console.WriteLine("Имя: {0}\nГруппа: {1}\nОценка: {2}\nДоход семьи: {3}\nСемья: {4}\nПол: {5}\nВид учебы: {6}", item.StudentName, item.Group, item.Mark, item.FamilyIncome, item.StudentFamily, item.Gender, item.StudyType);
                    Console.WriteLine("--------------------");
                }
            }
            else if (ch == 5)
            {
                List<Student> newS = s.FindAll(s => s.FamilyIncome < 2000 && s.StudentFamily == studentFamily.NotFull);
                foreach (Student item in newS)
                {                    
                    Console.WriteLine("Имя: {0}\nГруппа: {1}\nОценка: {2}\nДоход семьи: {3}\nСемья: {4}\nПол: {5}\nВид учебы: {6}", item.StudentName, item.Group, item.Mark, item.FamilyIncome, item.StudentFamily, item.Gender, item.StudyType);
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
}
