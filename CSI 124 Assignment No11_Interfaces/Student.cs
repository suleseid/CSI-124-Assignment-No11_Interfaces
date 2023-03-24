﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Assignment_No11_Interfaces
{
    internal class Student
    {
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public Student(string v1, string v2)
        {
        }

        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public double Average()
        {
            return (_csiGrade + _genEdGrade) / 2.0;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} - {_csiGrade} {_genEdGrade}";
        }
    }
    
}
