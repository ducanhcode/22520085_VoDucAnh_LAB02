using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22520085_VoDucAnh
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Course1 { get; set; }
        public float Course2 { get; set; }
        public float Course3 { get; set; }
        public float Average { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}, Phone: {Phone}, Course1: {Course1}, Course2: {Course2}, Course3: {Course3}, Average: {Average}";
        }
    }
}
