using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static List<mrtGoal> mrtgoalList = new List<mrtGoal>();
    static int mrtpoints = 0;
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to your Eternal Quest!");
        string mrtentry = "";
        while(mrtentry != "6")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.Write("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \n");
            mrtentry = Console.ReadLine();
            Console.Clear();
            if(mrtentry == "1")
            {
                mrtCreateNewGoal();
            }
            else if(mrtentry == "2")
            {
                Console.WriteLine($"You have {mrtpoints} points");
                Console.WriteLine(string.Concat("Your goals are:", mrtListGoals()));
            }
            else if(mrtentry == "3")
            {

                Console.WriteLine("What do you want to save the file as?");
                string mrtFileName = Console.ReadLine();
                mrtSaveGoals(mrtFileName);
            }
            else if(mrtentry == "4")
            {   
                Console.WriteLine("What is the name of the file you wish to load?");
                string mrtFileName = Console.ReadLine();
                mrtLoadGoals(mrtFileName);
            }
            else if(mrtentry == "5")
            {
                int _pointsGained = mrtRecordEvent();
                Console.WriteLine($"You just gained {_pointsGained} points!");
                mrtpoints+=_pointsGained;
            }
            else if(mrtentry != "6")
            {
            Console.WriteLine("Sorry, that isn't a valid entry. Please try again!");
            }
        }
    }
    static void mrtCreateNewGoal()
    {
        string _userEntry;
        mrtGoal _returnGoal;
        Console.WriteLine("What type of goal do you want to make?"); 
        Console.Write("1. Simple Goal \n2. Eternal Goal \n3. Check List Goal \n");
        _userEntry = Console.ReadLine();
        if(_userEntry == "1")
        {
        Console.Write("What is the name of the goal? "); 
        string _goalName = Console.ReadLine();
        Console.Write("What is the description of the goal? "); 
        string _goalDescription = Console.ReadLine();
        Console.Write("How many points is it worth? "); 
        string _goalPoints = Console.ReadLine();
        _returnGoal = new mrtSimple(_goalName, _goalDescription, int.Parse(_goalPoints));
        mrtgoalList.Add(_returnGoal);
        }
        else if(_userEntry == "2")
        {
        Console.WriteLine("What is the name of the goal?"); 
        string _goalName = Console.ReadLine();
        Console.WriteLine("What is the description of the goal?"); 
        string _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is each completion worth?"); 
        string _goalPoints = Console.ReadLine();
        _returnGoal = new mrtEternal(_goalName, _goalDescription, int.Parse(_goalPoints));
        mrtgoalList.Add(_returnGoal);
        }
        else if(_userEntry == "3")
        {
        Console.WriteLine("What is the name of the goal?"); 
        string _goalName = Console.ReadLine();
        Console.WriteLine("What is the description of the goal?"); 
        string _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is each completion worth?"); 
        string _goalPoints = Console.ReadLine();
        Console.WriteLine("How many bonus points is completion of the list worth?"); 
        string _goalBonus = Console.ReadLine();
        Console.WriteLine("How many times can you complete it?"); 
        string _goalTotal = Console.ReadLine();
        _returnGoal = new mrtCheckList(_goalName, _goalDescription, int.Parse(_goalPoints), int.Parse(_goalBonus), int.Parse(_goalTotal));
        mrtgoalList.Add(_returnGoal);
        }
        else
        {
            Console.WriteLine("Sorry, that's not a valid input.");
        }
    }

    static string mrtListGoals()
    {
        string _returnString = "";
        int i = 0;
            foreach(mrtGoal _goal in mrtgoalList)
            {
                i++;
                _returnString = string.Concat(_returnString, $"\n{i}. ", _goal.mrtToString());
            }
        return _returnString;
    }
    static void mrtSaveGoals(string _filePath)
    {
        using (StreamWriter _writerObj = new StreamWriter(_filePath, false))
        {
            _writerObj.WriteLine(mrtpoints);
            foreach(mrtGoal goal in mrtgoalList)
            {
                _writerObj.WriteLine(goal.mrtToCSV());
            }
        }
        Console.WriteLine($"File saved to: {_filePath}");
    }

    static void mrtLoadGoals(string p_fileName)
    {
        if (File.Exists(p_fileName))
        {
            
            using (StreamReader _readerObj = new StreamReader(p_fileName))
            {
                mrtgoalList.Clear();
                string _pointsString = _readerObj.ReadLine();
                mrtpoints = int.Parse(_pointsString);
                string _line = _readerObj.ReadLine();
                while (_line != null)
                {
                    string[] _linehalves = _line.Split(":");
                    string _goalType = _linehalves[0];
                    string[] _goalParts = _linehalves[1].Split(",");
                    string _name = _goalParts[0];
                    string _description = _goalParts[1];
                    string _points = _goalParts[2];
                    mrtGoal _constructedGoal;
                    if(_goalType == "SimpleGoal")
                        {
                        string _completedString = _goalParts[3];
                        bool _completed = bool.Parse(_completedString);
                        _constructedGoal = new mrtSimple(_name, _description, int.Parse(_points), _completed);
                        mrtgoalList.Add(_constructedGoal);
                        }
                        else if(_goalType == "EternalGoal")
                        {
                        _constructedGoal = new mrtEternal(_name, _description, int.Parse(_points));
                        mrtgoalList.Add(_constructedGoal);
                        }
                        else if(_goalType == "CheckListGoal")
                        {
                         
                        string _completed = _goalParts[3];
                        string _goalBonus = _goalParts[4];
                        string _goalTotal = _goalParts[5];
                        string _goalCurrent = _goalParts[6];
                        _constructedGoal = new mrtCheckList(_name, _description, int.Parse(_points), int.Parse(_goalBonus), int.Parse(_goalTotal), int.Parse(_goalCurrent), bool.Parse(_completed));
                        mrtgoalList.Add(_constructedGoal);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Goal Type in CSV");
                        }

                    _line = _readerObj.ReadLine();
                }
            }
        }
        else
        {
            Console.WriteLine($"File not found: {p_fileName}");
        }
    }
    static int mrtRecordEvent()
    {
        int _returnInt;
        Console.WriteLine(string.Concat("Please select one of the following goals to record:", mrtListGoals()));
        string _userEntry = Console.ReadLine();
        _returnInt = mrtgoalList[int.Parse(_userEntry) - 1].mrtRecordEvent();
        return _returnInt;
    }

}