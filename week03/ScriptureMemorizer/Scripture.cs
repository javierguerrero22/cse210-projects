using System;
class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');

        List<Word> wordList = new List<Word>();

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }
        _words = wordList;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int totalWords = _words.Count;
        numberToHide = Math.Min(numberToHide, totalWords);

        List<int> hiddenIndex = new List<int>();
        while (hiddenIndex.Count < numberToHide)
        {
            int aleatoryIndex = random.Next(totalWords);

            if (!hiddenIndex.Contains(aleatoryIndex))
            {
                hiddenIndex.Add(aleatoryIndex);
            }
        }
        foreach (int index in hiddenIndex)
        {
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        List<string> visibleWords = new List<string>();
        foreach (Word word in _words)
        {
            visibleWords.Add(word.DisplayText());
        }
        string result = string.Join(" ", visibleWords);
        return reference +" "+ result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;        
    }

}