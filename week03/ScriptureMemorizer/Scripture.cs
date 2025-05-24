// I did an unhide functionality for exceeding requirements. Look for comments below.
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden()) break;
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    // Creativity and exceeding requirements: Unhide words
    public void UnhideRandomWords(int numberToUnhide)
    {
        Random rand = new Random();
        int unhiddenCount = 0;

        while (unhiddenCount < numberToUnhide)
        {
            int index = rand.Next(_words.Count);

            if (_words[index].IsHidden())
            {
                _words[index].Show();
                unhiddenCount++;
            }

            if (!AnyWordsHidden()) break;
        }
    }

    public bool AnyWordsHidden()
    {
        foreach (var word in _words)
        {
            if (word.IsHidden()) return true;
        }
        return false;
    }


    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
}
