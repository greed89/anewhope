using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    private static TextManager instance = null;

    private TextManager()
    {
        Debug.Log("TextManager Created");
    }

    public void ShowText()
    {
        Debug.Log("TextManager ShowText");
    }

    public static TextManager Instance
    {
        get
        {
            if (instance == null)
                instance = new TextManager();
            return instance;
        }
    }
}
