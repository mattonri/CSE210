

public class mrtScripture
{
    private mrtPassage passage;
    private mrtReference reference;

    public mrtScripture(string _reference, string _passage)
    {
        passage = new mrtPassage(_passage);
        reference = new mrtReference(_reference);
    }
    public string mrtReturnString()
    {
        string _returnString = $"{reference.mrtReturnString()}\n{passage.mrtReturnString()}";
        return _returnString;
    }
    public bool mrtHideWord()
    {
        return passage.mrtHideWord();
    }
}