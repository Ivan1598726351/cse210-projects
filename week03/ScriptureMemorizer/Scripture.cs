using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference=reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 1; i <= numberToHide; i++)
        {
            int integer = random.Next(_words.Count);
            _words[integer].Hide();
        }
            

    } 


    public string GetDisplayText()
    {
        string ourText="";
        foreach (Word word in _words)
        {
            ourText=ourText+word.GetDisplayText() + " ";

        }

        return _reference.GetDisplayText()+" "+ourText;
    }
        
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
    
}