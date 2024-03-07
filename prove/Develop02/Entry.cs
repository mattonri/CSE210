

public class mrtEntry 
{

    // class variables
    public string mrtdate;
    public string mrtprompt;
    public string mrtresponse;

    public mrtEntry()
    {

    }
    public string mrtReturnString()
    {
        string _constructedString = $"Entry on {mrtdate}\nPrompt: {mrtprompt}\nResponse: {mrtresponse}";
        return _constructedString;
    }
    public string mrtCSVFormat()
    {
        // replace double quotes and commas with || and // respectively as they aren't commonly used (especially two in a row like that) and format into Excel readable CSV lines
        string _formattedDate = mrtdate.Replace("\"", "||").Replace(",", "//");
        string _formattedPrompt = mrtprompt.Replace("\"", "||").Replace(",", "//");
        string _formattedResponse = mrtresponse.Replace("\"", "||").Replace(",", "//");
        string _CSVFormattedString = $"\"{_formattedDate}\",\"{_formattedPrompt}\",\"{_formattedResponse}\"";
        return _CSVFormattedString;

    }
}