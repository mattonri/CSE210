// Written by Matt Talbert on 3/6/2024
// To show creativity, I made the CSV files readable by excel with a headerfile and appropriately divided elements with double quotes and commas handlded.
using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {

        string mrtUserPrompt = "";
        string mrtUserResponse = "";
        mrtJournal mrtUserJournal = new mrtJournal();
        string mrtentry = "";
        while(mrtentry != "5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.Write("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit\n");
            mrtentry = Console.ReadLine();
            if(mrtentry == "1"){
                mrtUserPrompt = mrtPickRandomPrompt();
                Console.WriteLine(mrtUserPrompt);
                mrtUserResponse = Console.ReadLine();
                mrtUserJournal.mrtAddEntry(_prompt:mrtUserPrompt, _response:mrtUserResponse);
            }
            else if(mrtentry == "2")
            {
                Console.WriteLine(mrtUserJournal.mrtReturnString());
            }
            else if(mrtentry == "3")
            {
                Console.WriteLine("What is the name of the journal you would like to load?");
                string mrtLoadJournalName = Console.ReadLine();
                mrtUserJournal = mrtLoad(mrtLoadJournalName);
            }
            else if(mrtentry == "4")
            {   
                Console.WriteLine("What would you like to name this journal?");
                mrtUserJournal.mrtjournalName = Console.ReadLine();
                mrtSave(mrtUserJournal);

            }
            else if(mrtentry != "5")
            {
            Console.WriteLine("Sorry, that isn't a valid entry. Please try again!");
            }
        }
    }
    static string mrtPickRandomPrompt()
    {
        Random _randomObj = new Random();
        int _randomInt = _randomObj.Next(21);
        // also I learned arrays! I figured since the size of this one won't change I'll use it here.
        string[] _prompts = {"Reflect on three things you're grateful for today.",
            "Describe a moment that brought you joy.",
            "What is something you learned today?",
            "Write about a challenge you faced and how you overcame it.",
            "Describe a small act of kindness you witnessed or performed.",
            "Share a goal you're currently working towards.",
            "Write about a book, article, or podcast you found interesting.",
            "Reflect on a mistake you made and what you learned from it.",
            "Describe an experience that made you laugh.",
            "What is something that inspired you today?",
            "Write about a person who positively impacted your day.",
            "Share a memory from your past that came to mind today.",
            "Describe a place you'd like to visit someday and why.",
            "Reflect on a conversation you had that made you think deeply.",
            "What is a skill you'd like to improve, and how do you plan to do it?",
            "Write about something you did today that you're proud of.",
            "Describe a moment when you felt calm and at peace.",
            "Reflect on your current emotions and what might be causing them.",
            "What is something you're looking forward to in the near future?",
            "Write about a decision you made today and how you feel about it now."};
        return _prompts[_randomInt];
    }

    static void mrtSave(mrtJournal _journal)
    {
        string _filePath = _journal.mrtjournalName;
        using (StreamWriter _writerObj = new StreamWriter(_filePath, false))
        {
            _writerObj.WriteLine(_journal.mrtCSVFormat());
        }
        Console.WriteLine($"File saved to: {_filePath}");
    }

    static mrtJournal mrtLoad(string _fileName)
    {
        if (File.Exists(_fileName))
        {
            
            using (StreamReader _readerObj = new StreamReader(_fileName))
            {
                mrtJournal _loadedJournal = new mrtJournal();
                // skip the header line
                string _line = _readerObj.ReadLine();
                _loadedJournal.mrtjournalName = _fileName;
                _line = _readerObj.ReadLine();
                while (_line != null)
                {
                    //format it from Excel-compatible CSV to strings that can be added to mrtEntry objects and onto mrtentryList 
                    string[] _lineParts = _line.Split(",");
                    string _loadedPrompt = _lineParts[1].Trim().Trim('\"').Replace("||", "\"").Replace("//", ",");
                    string _loadedResponse = _lineParts[2].Trim().Trim('\"').Replace("||", "\"").Replace("//", ",");
                    string _loadedDate = _lineParts[0].Trim().Trim('\"').Replace("||", "\"").Replace("//", ",");
                    _loadedJournal.mrtAddEntry(_prompt:_loadedPrompt, _response:_loadedResponse, _date:_loadedDate);
                    _line = _readerObj.ReadLine();
                }
                return _loadedJournal;
            }
        }
        else
        {
            mrtJournal _loadedJournal = new mrtJournal();
            Console.WriteLine($"File not found: {_fileName}");
            return _loadedJournal;
        }
    }


}