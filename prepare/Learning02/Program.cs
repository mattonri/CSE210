using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myresume = new Resume();
        myresume.AddJob(_company:"Microsoft",_jobTitle:"Software Engineer",_startYear:2019,_endYear:2022);
        myresume.AddJob(_company:"Apple",_jobTitle:"Manager",_startYear:2022,_endYear:2023);
        myresume._name = "Allison Rose";
        myresume.DisplayResume();
    }
}