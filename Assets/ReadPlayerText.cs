using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadPlayerText : MonoBehaviour
{

    public Text getText;

    // Start is called before the first frame update
    void Start()
    {
        getText = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        foreach(char c in Input.inputString) 
        { 
            if (c == '\b') // has backspace/delete been pressed?
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
                getText.text += c;
            }
        }
    }
}
