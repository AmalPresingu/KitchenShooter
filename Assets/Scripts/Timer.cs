/*  
 *  10/12/2021
 *  Creating timer to countdown seconds
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 30f; //30 seconds

    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; //setting current time to 30 seconds
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; //updating each second
        countdownText.text = currentTime.ToString("0"); //ui text

        if (currentTime <= 0) //making sure that ui doesn't go below 0
        {
            currentTime = 0;
        }
    }
}
