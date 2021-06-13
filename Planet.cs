using System;
using System.Collections.Generic;
using System.Text;

namespace KursovaRabota
{
    internal class Planet : Star
    {
        public string name3 { get; private set; }
        public string type3 { get; private set; }
        public int age3 { get; private set; }
        public int supportLife3 { get; private set; }


        public Planet(string planetName, string planetType, int planetAge, int supportLife,
            string starName, string starClass, double starMass, double starSize, int starTemperature, double starBrightness,
            string name, string type, int age) : base(starName, starClass, starMass, starSize, starTemperature, starBrightness, name, type, age)
        {
            this.name3 = planetName;
            this.type3 = planetType;
            this.supportLife3 = supportLife;
            this.age3 = planetAge;
        }
    }
}
