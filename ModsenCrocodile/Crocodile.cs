using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenCrocodile
{
    internal class Crocodile
    {
        public string Name { get; }
        public double Weight { get; }
        public double Length { get; }
        public int Age { get; }
        public string Gender { get; }

        public Crocodile(string name, double weight, double length, int age, string gender)
        {
            Name = name;

            Weight = weight;

            Length = length;

            Age = age;

            Gender = gender;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Вес: {Weight}, Длина: {Length}, Возраст: {Age}, Пол: {Gender}";
        }
    }
}
