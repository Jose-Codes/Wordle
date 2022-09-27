using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReadPlayerText : MonoBehaviour
{
    private GameManager GM;
    public TextMeshProUGUI getText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(char c in Input.inputString) 
        {
            if (getText.text.Length == 5) break;

            else if (c == '\b') // has backspace/delete been pressed?
            {
                if (getText.text.Length != 0)
                {
                    getText.text = getText.text.Substring(0, getText.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                print("User entered: " + getText.text);
            }
            else
            {
                // check valid
                if (validInput(c))
                    getText.text += System.Char.ToUpper(c);
                else
                    Debug.Log("Invalid character: " + (int)c);
            }
        }
    }


    /*
     Errors:
     1) Must be ASCII values 65-90 or 97-122
     */
    bool validInput(char c)
    {
        if ((65 <= (int)c && (int)c <= 90) || (97 <= (int)c && (int)c <= 122))
            return true;

        return false;
    }
}
