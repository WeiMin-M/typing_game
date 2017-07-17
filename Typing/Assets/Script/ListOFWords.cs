﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

public class ListOFWords : MonoBehaviour {
    public static List<string> words = new List<string>();
    public static List<string> bossWords = new List<string>();
    public static List<string> loadedWords = new List<string>();
    int lowestWordCount = 0;
    int highestWordCount = 0;

    // Use this for initialization
    void Start()
    {
        words.Clear();
        bossWords.Clear();


        if (Global.readFile == false)
        {
            string path = "Assets/Resources/English.txt";

            using (StreamReader sr = new StreamReader(Application.streamingAssetsPath + "/English.txt"))
            {
                string line; // this is the buffer for the content from your file
                while ((line = sr.ReadLine()) != null)
                {
                    loadedWords.Add(line);
                }
            }
            Global.readFile = true;
        }
        if (PlayerPrefs.GetInt("AllowUpper") == 0)
            Global.allowUpperCase = true;
        else
            Global.allowUpperCase = false;


        if (PlayerPrefs.GetInt("AllowSymbols") == 0)
            Global.allowSymbols = true;
        else
            Global.allowSymbols = false;


        Regex r = new Regex("^[a-zA-Z0-9]*$");
        lowestWordCount = loadedWords[0].Length;
        highestWordCount = loadedWords[0].Length;
 
        foreach (string word in loadedWords)
        {
            int n = word.Length;
            StringBuilder sb = new StringBuilder(word);

            //Easy
            if (Global.difficultyLevel < 2)
            {
                if (GoToScene.GetSceneName() == "1")
                {
                    if (n == lowestWordCount)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                for (int i = 0; i < n; i++)
                                {
                                    int random = Random.Range(0, 100);
                                    if (random < 20)
                                        sb[i] = char.ToUpper(word[i]);
                                }
                                words.Add(sb.ToString());
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 20)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());

                                }
                            }
                        }
                    }
                }

                if (GoToScene.GetSceneName() == "2")
                {
                    if (n >= 2 && n <= 4)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    int random = Random.Range(0, 100);
                                    if (random < 20)
                                        sb[i] = char.ToUpper(word[i]);
                                }
                                words.Add(sb.ToString());
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 20)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                    }
                }
                if (GoToScene.GetSceneName() == "3")
                {
                    if (Global.allowSymbols)
                    {
                        if (!Global.allowUpperCase)
                        {
                            if (word == word.ToLower())
                            {
                                words.Add(word);
                                if (n >= 3 && n <= 4)
                                    bossWords.Add(word);
                            }
                            else
                            {
                                words.Add(word);
                                if (n >= 3 && n <= 4)
                                    bossWords.Add(word);
                            }
                        }
                        else
                        {
                            words.Add(word);
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    int random = Random.Range(0, 100);
                                    if (random < 20)
                                        sb[i] = char.ToUpper(word[i]);
                                }
                                words.Add(sb.ToString());
                            }
                            if (n >= 3 && n <= 4)
                                bossWords.Add(word);
                        }

                    }
                    else
                    {
                        if (r.IsMatch(word))
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                    if (n >= 3 && n <= 4)
                                        bossWords.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 20)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                                if (n >= 3 && n <= 4)
                                    bossWords.Add(word);
                            }
                        }
                    }
                }
            }
            //Normal
            if (Global.difficultyLevel >= 2 && Global.difficultyLevel < 3)
            {
                if (GoToScene.GetSceneName() == "1")
                {
                    if (n >= 2 && n <= 4)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 40)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 40)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                if (GoToScene.GetSceneName() == "2")
                {
                    if (n >= 4 && n <= 5)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 40)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 40)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                if (GoToScene.GetSceneName() == "3")
                {
                    if (n >= 3)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 40)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 40)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                    if (n >= 4)
                        bossWords.Add(word);
                }
            }
            //Hard
            if (Global.difficultyLevel >= 3)
            {
                if (GoToScene.GetSceneName() == "1")
                {
                    if (n >= 4 && n <= 5)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 70)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 70)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                if (GoToScene.GetSceneName() == "2")
                {
                    if (n >= 7 && n <= 9)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            else
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 70)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                else
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 70)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                if (GoToScene.GetSceneName() == "3")
                {
                    if (n >= 5)
                    {
                        if (Global.allowSymbols)
                        {
                            if (!Global.allowUpperCase)
                            {
                                if (word == word.ToLower())
                                {
                                    words.Add(word);
                                }
                            }
                            {
                                words.Add(word);
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        int random = Random.Range(0, 100);
                                        if (random < 70)
                                            sb[i] = char.ToUpper(word[i]);
                                    }
                                    words.Add(sb.ToString());
                                }
                            }
                        }
                        else
                        {
                            if (r.IsMatch(word))
                            {
                                if (!Global.allowUpperCase)
                                {
                                    if (word == word.ToLower())
                                    {
                                        words.Add(word);
                                    }
                                }
                                {
                                    words.Add(word);
                                    {
                                        for (int i = 0; i < n; i++)
                                        {
                                            int random = Random.Range(0, 100);
                                            if (random < 70)
                                                sb[i] = char.ToUpper(word[i]);
                                        }
                                        words.Add(sb.ToString());
                                    }
                                }
                            }
                        }
                    }
                    if (n >= 6)
                        bossWords.Add(word);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}