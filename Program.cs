using System;
using System.Collections.Generic;

namespace KursovaRabota
{
    class Program
    {
        static void Main(string[] args)
        {
            // V class galaxy - name, type(elliptical, lenticular, spiral, irregular), age;
            // V class star - name, class(M, K, G, F, A, B, O), mass(M☉), size(R☉), tempreature(K)[int], brightness(L☉);
            // V class planet - name, type(terrestrial,giant planet,ice giant,mesoplanet,mini - neptune,planetar,super - earth,super - jupiter,sub-earth), bool(habitable);
            // V class moon - name;

            //commands:

            //add galaxy [<galaxy name>] <type> <age>
            //add star [<galaxy name>] [<star name>] <mass> <size> <temp> <luminosity>
            //add planet [<star name>] [<planet name>] <planet type> <support life>
            //add moon[< planet name >] [< moon name >]
            //list galaxies
            //list stars
            //list planets
            //list moons
            //stats
            //print [<galaxy name>]
            // V exit

            string command = "";
            string starClass = "";
            int countGalaxies = 0;
            int countStars = 0;
            int countPlanets = 0;
            int countMoons = 0;
            var galaxyList = new List<GalaxyList> { };
            
            while (command != "exit")
            {
                command = Console.ReadLine();
                string[] commandList = command.Split();

                if (commandList[0] == "add")
                {
                    if (commandList[1] == "galaxy")
                    {
                        string name = commandList[2];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var x in charsToRemove)
                        {
                            name = name.Replace(x, string.Empty);
                        }
                        
                        Galaxy galaxy = new Galaxy(name, commandList[3], int.Parse(commandList[4]));
                        galaxy.name1 = name;
                        galaxy.type1 = commandList[3];
                        galaxy.age1 = int.Parse(commandList[4]);
                        new GalaxyList
                        {
                            nameList = galaxy.name1, typeList= galaxy.type1, ageList = galaxy.age1
                        };
                        countGalaxies++;

                    }
                    else if (commandList[1] == "star")
                    {
                        if(int.Parse(commandList[5])>= 6.6)
                        {
                            starClass = "O";
                        }
                        else if (int.Parse(commandList[5]) < 6.6 && int.Parse(commandList[5]) > 1.8)
                        {
                            starClass = "B";
                        }
                        else if (int.Parse(commandList[5]) <= 1.8 && int.Parse(commandList[5]) > 1.4)
                        {
                            starClass = "A";
                        }
                        else if (int.Parse(commandList[5]) <= 1.4 && int.Parse(commandList[5]) > 1.15)
                        {
                            starClass = "F";
                        }
                        else if (int.Parse(commandList[5]) <= 1.15 && int.Parse(commandList[5]) > 0.96)
                        {
                            starClass = "G";
                        }
                        else if (int.Parse(commandList[5]) <= 0.96 && int.Parse(commandList[5]) > 0.7)
                        {
                            starClass = "K";
                        }
                        else
                        {
                            starClass = "M";
                        }
                        
                    }
                    else if (commandList[1] == "planet")
                    {

                    }
                    else if (commandList[1] == "moon")
                    {

                    }
                    else
                    {
                        Console.WriteLine($"{commandList[1]} can't be added to our research. Please try with another command.");
                    }
                }
                else if (commandList[0] == "list")
                {
                    if (commandList[1] == "galaxies")
                    {

                    }
                    else if (commandList[1] == "stars")
                    {

                    }
                    else if (commandList[1] == "planets")
                    {

                    }
                    else if (commandList[1] == "moons")
                    {

                    }
                    else
                    {
                        Console.WriteLine($"There is no list for {commandList[1]}. Please try with another command.");
                    }
                }
                else if (commandList[0] == "stats")
                {
                    Console.WriteLine($"--- Stats ---");
                    Console.WriteLine($"Galaxies: {countGalaxies}");
                    Console.WriteLine($"Stars: {countStars}");
                    Console.WriteLine($"Planets: {countPlanets}");
                    Console.WriteLine($"Moons: {countMoons}");
                    Console.WriteLine($"--- End of stats ---");
                }
                else if (commandList[0] == "print")
                {
                    Console.WriteLine("--- Data for {galaxyName} galaxy ---");
                    Console.WriteLine("Type: type");
                    Console.WriteLine("Age: age");
                    Console.WriteLine("Stars:");
                    Console.WriteLine("--- End of data for {galaxyName} galaxy ---");
                }
                else if (commandList[0] == "exit")
                {

                }
                else
                {
                    Console.WriteLine("Sorry, but the command you have entered is wrong. Please try another one.");
                }
            }


        }
    }
}
