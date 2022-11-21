using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    internal class Student
    {
        private string name;
        private string lastName;
        private string patronymic;
        private int age;
        private string group;
        private int[][] marks = new int[3][];
        public Student() : this("NoName","NoName","NoName",0,"NoName")
        {
            marks[0] = new int[20];
            marks[1] = new int[10];
            marks[2] = new int[30];
           
        }
        public Student(string _name, string _lastName, string _patronymic, int _age, string _group)
        {
            Name = _name;
            LastName = _lastName;
            Patronymic = _patronymic;
            Age = _age;
            Group = _group;
            marks[0] = new int[20];
            marks[1] = new int[10];
            marks[2] = new int[30];
        }
        public void GetMark(int subj,int mark,int lesson_n)
        {
            if (lesson_n < marks[subj].Length||subj>3||subj<0)
                throw new IndexOutOfRangeException();
            marks[subj][lesson_n] = mark;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}\n Last Name:{lastName}\n Patronymic:{patronymic}\nAge:{age}\nGroup:{group}");
            Console.WriteLine("MARKS:");
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Programming:");
                        break;
                    case 1:
                        Console.WriteLine("Administration:");
                        break;
                    case 2:
                        Console.WriteLine("Design:");
                        break;
                }
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + ",");
                }
                Console.WriteLine();
            }
        }
        public int GetAvg(int subj)
        {
            int tmp = 0;
            for(int i = 0; i < marks[subj].Length;i++)
            {
                tmp += marks[subj][i];
            }
            tmp /= marks[subj].Length;
            return tmp;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Group
        {
            get => group;
            set => group = value;
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
    }
}
