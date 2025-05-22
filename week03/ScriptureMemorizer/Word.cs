using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string DisplayText()
    {
        return _isHidden ? "_____" : _text;
    }
}