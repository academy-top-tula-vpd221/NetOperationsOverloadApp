using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperationsOverloadApp
{
    internal class Student
    {
        public int Id { get; set; }
        int age;
        string name;
        string email;
        string phone;
        public string Name { get => name; set => name = value; }
        public string Email { set => email = value; get => email; }
        public string Phone { set => phone = value; get => phone; }
        public int Age { get => age; set => age = value; }

        public string this[string key]
        {
            set
            {
                switch (key)
                {
                    case "Name": name = value; break;
                    case "Email": email = value; break;
                    case "Phone": phone = value; break;
                    case "Age": age = Int32.Parse(value); break;
                    default: throw new Exception("Invalid key");
                }
            }
            get
            {
                return key switch
                {
                    "Name" => name,
                    "Email" => email,
                    "Phone" => phone,
                    "Age" => age.ToString(),
                    _ => throw new Exception("Invalid key")
                };
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Group
    {
        string title;
        public int Count { get; }
        Student[] students;
        public Group(int count = 5)
        {
            Count = count;
            students = new Student[count];
        }

        public Student this[int index]
        {
            set
            {
                if(index >=0 && index < students.Length)
                    students[index] = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
            get
            {
                if(index >= 0 && index < students.Length)
                    return students[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string this[string key]
        {
            get => title;
            set => title = value;
        }

    }
}
