using System;

namespace QR_AttendanceControl
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public Student(string id, string name, string surname, string middleName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
        }

        public Student(string id)
        {
            Id = id;
        }
    }
}
