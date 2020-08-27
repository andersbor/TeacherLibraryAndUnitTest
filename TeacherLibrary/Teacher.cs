using System;

namespace TeacherLibrary
{
    public class Teacher
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
