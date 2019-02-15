namespace Counter.Models
{
  public class Word
  {
    private string _myWord;

    public Word (string myWord)
    {
      _myWord = myWord;
    }

    public string GetWord()
    {
      return _myWord;
    }

    public void SetWord(string newWord)
    {
      _myWord = newWord;
    }

    public bool ValidateWord(string myWord)
    {
      if (myWord == "")
      {
        return false;
      }
      else if (myWord.Contains(" "))
      {
        return false;
      }
      return true;
    }
  }
}
