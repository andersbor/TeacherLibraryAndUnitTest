using System;

namespace TeacherLibrary
{
    public class Teacher
    {
        private int _salary;
        private string _name;
        public static readonly double Pi = Math.PI;

        public Teacher(string name)
        { Name = name; }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 1) throw new ArgumentException();
                _name = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
