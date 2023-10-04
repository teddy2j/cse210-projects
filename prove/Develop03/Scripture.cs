using System.Diagnostics.Metrics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        string[] textList = text.Split(" ");
        int i = 0;
        while (i < textList.Length)
        {
            Word word = new Word(textList[i]);
            _words.Add(word);
            i += 1;
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        // checking first if numberTohide is less or equal// 
        //than the number of not-hidden words//
        int count = 0;
        foreach(Word word in _words)
        {
            if (word.IsHidden()==false)
            {
                count += 1;
            }        
        }

        if (count >= numberToHide)
        {
            //this will hide "numberToHide" words//
            Random random = new Random();
            int i = 1;
            while (i <= numberToHide )
            {           
                int randomNumber = random.Next(0, _words.Count);
                if (_words[randomNumber].IsHidden() == false)
                {
                    _words[randomNumber].Hide();
                    i += 1;
                }
            }
        }

        //this will hide the remaining last words//
        //in case count < numberToHide//
        else
        {
            foreach(Word word in _words)
            {
                word.Hide();
            }
        }    
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach(Word word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + " " + text;
    }

    public bool IsCompletelyHidden()
    {
        bool value = true;

        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                value = false;
            }
        }
        return value;

        }
}