using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSam2
{

    struct Student
    {
        string fio;
        int group;
        int informatic;
        int physic;
        int history;

        public Student(string fio, int group, int informatic, int physic, int history) : this()
        {
            this.Fio = fio;
            this.Group = group;
            this.Informatic = informatic;
            this.Physic = physic;
            this.History = history;
            pupils = new List<Student>();
        }

        public static List<Student> pupils;

        public string Fio { get; set; }
        public int Group { get; set; }
        public int Informatic { get; set; }
        public int Physic { get; set; }
        public int History { get; set; }

        //public Student(string fio, int group, int informatic, int physic, int history)
        //{
        //    Fio = fio;
        //    Group = group;
        //    Informatic = informatic;
        //    Physic = physic;
        //    History = history;
        //    //pupils = new List<Student>();
        //}

        public string MiddleBall()
        {
            for (int i = 1; i < pupils.Count; i++)
            {
                if ((Informatic + Physic + History) / 3 > 4)
                {
                    Console.WriteLine($"Ученик {i}: Имя: {pupils[i].fio}, Средний балл {(Informatic + Physic + History) / 3}");
                }
            }
        }
        public void Show()
        {
            if (pupils.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            else
            {
                for (int i = 1; i < pupils.Count; i++)
                {
                    Console.WriteLine($"{i} Ученик:\nФИО: {pupils[i].Fio}, Группа: {pupils[i].Group}, Информатика: {pupils[i].Informatic}, Физика: {pupils[i].Physic}, \nИстория: {pupils[i].History}, Средний балл: {pupils[i].Informatic + pupils[i].Physic + pupils[i].History/3:f2}\n");
                }
            }

        }
        static public void AddPupil()
        {
            {
                Console.WriteLine("Введите ФИО ученика:");
                string fio = Console.ReadLine();
                Console.WriteLine("Введите номер группы:");
                int group = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике:");
                int informatic = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике:");
                int physic = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценку по истории:");
                int history = Convert.ToInt32(Console.ReadLine());
                pupils.Add(new Student(fio,group,informatic,physic,history));
            }
        }
    }
}
