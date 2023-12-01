using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Program
    {
        
        public interface IEmployee
        {
            void Work();
        }
        public interface Study_INT
        {
            void Study();
        }
        public interface Teacher_INT
        {
            void Teach();
        }
        static void Main(string[] args)
        {
            admin admin1 = new admin("Пётр Иван Петрович","10.01.1901", 23);
            Student student1 = new Student("Антон Александрович Николаев","17.03.2000","Подготовки врачей",34);
            teacher teacher1 = new teacher("Николаев Александр Павлович","16.05.1981","Стоматологии","доцент", 15);
            manager manager1 = new manager("Николай Палович Антонов","31.01.1965","Лесной Промышленности","Менеджер");
            List<object> persons_list = new List<object> { admin1, student1,teacher1,manager1 };
            foreach(object person in persons_list)
            {
                Console.WriteLine(person);
            }
            admin1.Work();
            student1.Work();
            teacher1.Work();
            manager1.Work();
            student1.Study();
            teacher1.Teach();

            Console.ReadLine();
        }
        abstract class Person :IEmployee
        {
            public abstract void Work();
            
        }
        abstract class Student1 : Study_INT
        {
            public abstract void Study();

        }
        abstract class teacher1 : Teacher_INT
        {
            public abstract void Teach();

        }



        class admin: Person
        {
            public admin(string name1, string date1, int lab1)
            {
                name = name1;
                date_birth = date1;
                lab_number = lab1;
                idcard = lab_number + 150;
            }
            string name;
            string date_birth;
            int lab_number;
            int idcard {get;}
            public override void Work() => Console.WriteLine("Admin is working");
            public override string ToString()
            {
                return string.Format($"ФИО: {name} Дата рождения: {date_birth} Номер лаборатории: {lab_number} Id#:{idcard}");
            }
        }
        class Student : Person, Study_INT
        {
            
            public Student(string name1, string date_birth1, string faculty1, int group1)
            {
                 name = name1;
                 date_birth = date_birth1;
                 faculty = faculty1;
                 group = group1;
                idcard = group + 13;
            }
            string name;
            string date_birth;
            string faculty;
            int group;
            int idcard { get; }
            public override string ToString()
            {
                return string.Format($"ФИО: {name} Дата рождения: {date_birth} Факультет: {faculty} Группа: {group} Id#:{idcard}");
            }
            public override void Work() => Console.WriteLine("Student is studying");
            public  void Study() => Console.WriteLine("The student is learning new things");
        }
        class teacher : Person, Teacher_INT
        {
            public teacher(string name1, string date_birth1, string faculty1, string job1, int staj1)
            {
                 name = name1;
                 date_birth = date_birth1;
                 faculty = faculty1;
                 job = job1;
                 staj = staj1;
                idcard = 324;
            }
            string name;
            string date_birth;
            string faculty;
            string job;
            int staj;
            int idcard { get; }
            public void Teach() =>Console.WriteLine("Teacher is teaching the science");
            
            public override string ToString()
            {
                return string.Format($"ФИО: {name} Дата рождения: {date_birth} Факультет: {faculty} Должность: {job} Стаж: {staj} Id#:{idcard}");
            }
            public override void Work() => Console.WriteLine("Teacher is in lab");
           
        }
        class manager : Person
        {
            public manager(string name1, string date_birth1, string faculty1,string job1)
            {
                name = name1;
                date_birth = date_birth1;
                faculty = faculty1;
                job = job1;
                idcard = 5345;
            }

            string name;
            string date_birth;
            string faculty;
            string job;
            int idcard { get; }
            public override string ToString()
            {
                return string.Format($"ФИО: {name} Дата рождения: {date_birth} Факультет: {faculty} Должность: {job} Id#:{idcard}");
            }
            public override void Work() => Console.WriteLine($"Manager is working at a {faculty} faculty");
        }
    }
}
