using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ListOfRecords : MonoBehaviour
{
    static string list = File.ReadAllText("Assets/files/Records.ψna");
    //static string list = "22|Alex 32|Den 2|Mike 21|Jeka";    example of text in file
    public static string[] recordsList = list.Split(' ');
    [SerializeField]
    Text records;

    void Start()
    {
        records.text = CalculateRecords(recordsList);
    }

    string CalculateRecords (string[] arr)
    {
        string result = "";
        int[] points = new int[arr.Length];
        string[] names = new string[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            string name = arr[i].Remove(0, arr[i].IndexOf("|")+1);
            string score = arr[i].Remove(arr[i].IndexOf("|"));
            //print(arr[i]);
            names[i] = name;
            //print(name);
            points[i] = Convert.ToInt32(score);
            //print(score);
        }

        //Kind of bubble sort
        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if( points[j+1] < points[j])
                {
                    int p = points[j];
                    string n = names[j];
                    points[j] = points[j + 1];
                    names[j] = names[j = 1];
                    points[j + 1] = p;
                    names[j + 1] = n;
                }
            }
        }

        Array.Reverse(names);
        Array.Reverse(points);

        for (int i = 0; i < arr.Length && i < 10; i++)
        {
            result += i+1 + "." + names[i] + "  -  " + points[i] + "\n";
            print(result);
        }
        return result;
    }
}
