using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int indexOfChar;

    public WordDisplay display;

    public Word (string _word,WordDisplay _display)
    {
        word = _word;
        indexOfChar = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[indexOfChar];
    }

    public void TypeLetter ()
    {
        indexOfChar++;
        display.RemoveLetter();
    }

    public bool WordTyped ()
    {
        bool wordTyped = (indexOfChar >= word.Length);
        //Debug.Log("wordTyped " + wordTyped);
        if (wordTyped)
        {
            display.RemoveWord();
        }
        return wordTyped;
    }

}
