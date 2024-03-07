using System;

public class mrtJournal
{

    // class variables
    public List<object> mrtentryList = new List<object>();
    public string mrtjournalName;

    public mrtJournal()
    {

    }

    public void mrtAddEntry(string _prompt,string _response, string _date="")
    {
        mrtEntry _entry = new mrtEntry();
        _entry.mrtprompt = _prompt;
        _entry.mrtresponse = _response;
        DateTime _systemTime = DateTime.Now;
        if(_date == "")
        {
            _date = _systemTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        _entry.mrtdate = _date;
        mrtentryList.Add(_entry);
    }
    public string mrtReturnString()
    {
        List<string> _entryStrings = new List<string>();
        foreach(mrtEntry _entry in mrtentryList)
        {
            _entryStrings.Add(_entry.mrtReturnString());
        }
        string _constructedString = string.Concat($"{mrtjournalName}\n" ,string.Join("\n", _entryStrings));
        return _constructedString;
    }
    public string mrtCSVFormat()
    {
        List<string> _entryStrings = new List<string>();
        foreach(mrtEntry _entry in mrtentryList)
        {
            _entryStrings.Add(_entry.mrtCSVFormat());
        }
        // Give it the appropriate header to be an Excel compatible format
        string _CSVFormattedString = string.Concat($"Date,Prompt,Response\n" ,string.Join("\n", _entryStrings));
        return _CSVFormattedString;
    }
}