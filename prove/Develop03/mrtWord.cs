

public class mrtWord
{
    private string word;
    private bool isHidden;

    public mrtWord(string _word, bool _isHidden=false)
    {
        isHidden = _isHidden;
        word = _word;
    }
    public void mrtHide()
    {
        isHidden = true;
    }
    public string mrtReturnString()
    {
        if(isHidden)
        {
            int _wordLength = word.Length;
            string _hiddenWord = "";
            for (int i = 0; i < _wordLength; i++)
            {
                _hiddenWord = string.Concat(_hiddenWord, "_");
            }
            return _hiddenWord;
        }
        else
        {
            return word;
        }
    }
    public bool mrtIsHidden()
    {
        return isHidden;
    }
}