using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Student
    {
        
              private int Id()
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public Student(int id, string name, string surname)
            {
            Id = id;
                Name = name;
                Surname = surname;
            }
        }
    }

