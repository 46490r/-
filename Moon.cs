using System;
using System.Collections.Generic;
using System.Text;

namespace KursovaRabota
{
    internal class Moon : Planet
    {
        public string moonName { get; private set; }
        public Moon(string moonName, string name, string type, int age, string starName, string starClass, double starMass, double starSize, int starTemperature, double starBrightness,
            string planetName, string planetType, int planetAge, int supportLife) : base(planetName, planetType, planetAge, supportLife, 
                starName, starClass, starMass, starSize, starTemperature, starBrightness, name, type, age)
        {
            this.moonName = moonName;
        }

    }
}
