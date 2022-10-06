using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessing : MonoBehaviour
{
    public Button guessButton;
    // Start is called before the first frame update
    void Start()
    {
        Button guessBtn = guessButton.GetComponent<Button>();
        guessBtn.onClick.AddListener(HandleButtonEevnt);
    }

    void HandleButtonEevnt()
    {
        Debug.Log("You have clicked the guess button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
