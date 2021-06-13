using System;
using System.Collections.Generic;
using System.Text;

namespace KursovaRabota
{
    internal class Star : Galaxy
    {
        public string name2 { get; private set; }
        public string class2 { get; private set; }
        public double mass2 { get; private set; }
        public double size2 { get; private set; }
        public int temperature2 { get; private set; }
        public double brightness { get; private set; }
        

        public Star(string starName,string starClass,double starMass,double starSize,int starTemperature,double starBrightness,
            string name, string type, int age) : base(name, type, age)
        {
        this.name2 = starName;
        this.class2 = starClass;
        this.mass2 = starMass;
        this.size2 = starSize;
        this.temperature2 = starTemperature;
        this.brightness = starBrightness;
        
        }
        
    }
}
