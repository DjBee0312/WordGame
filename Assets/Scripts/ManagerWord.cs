using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerWord : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        //print(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                //print("has active");
            }
        }
        else
        {
            foreach ( Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    GetComponent<Score>().GetWordLength(activeWord.word);
                    //print(activeWord.word + " active word");
                    GetComponent<Score>().SetStartTime();
                    //print("Found word " + activeWord.word);
                    break;

                }
            }
        }
        if (hasActiveWord && activeWord.WordTyped())
        {
            //print("finished word");
            GetComponent<Score>().increasePoints();
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
