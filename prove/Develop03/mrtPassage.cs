

public class mrtPassage
{
    private mrtWord[] passage;
    private List<int> unHiddenIndicies =  new List<int>();
    private bool _isAllHidden = false;

    public mrtPassage(string _passage)
    {
        string[] _wordList = _passage.Trim().Split();
        passage = new mrtWord[_wordList.Count()];
        for(int i = 0; i < _wordList.Count(); i++)
        {
            mrtWord _word = new mrtWord(_wordList[i]);
            passage[i] = _word;
            unHiddenIndicies.Add(i);
        }
    }
    public string mrtReturnString()
    {
        string _passageString = "";
        foreach (mrtWord _word in passage)
        {
            _passageString = $"{_passageString}{_word.mrtReturnString()} ";
        }
        
        return _passageString;
    }
    public bool mrtHideWord()
    {
        if (!_isAllHidden)
        {
        Random _randomGenerator = new Random();
        int _randomVerse = _randomGenerator.Next(0,unHiddenIndicies.Count());

        passage[unHiddenIndicies[_randomVerse]].mrtHide();
        unHiddenIndicies.Remove(unHiddenIndicies[_randomVerse]);
        
        if (unHiddenIndicies.Count() <= 0)
        {
            _isAllHidden = true;
        }
        }
        return _isAllHidden;
    }
}