using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// To do: 
/// 1) Make a counter that will end the game after 6 guesses
/// 2) Check that the length of the string is 5 characters
/// </summary>

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Assings the colors to the characters
    /// depending on their match.
    /// JAZZY
    /// FUZZY
    /// return: [-1, -1, 1, 1, 1]
    /// -1 --> Red
    /// 0 --> Yellow
    /// 1 --> Green
    /// </summary>
    int[] checkMatches()
    {
        // TO DO:
        // Implement colors
        int[] colors = new int[5];
        return colors;
    }
}
