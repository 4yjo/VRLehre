using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Tutorial https://www.youtube.com/watch?v=ulxXGht5D2U&t=553s
public class LevelTimer : MonoBehaviour
{
    public int startTimeMinutes;
    private int startTimeSeconds;
    public bool timerRunning = true; // can be set to false by other scripts to pause timer with FindObjectOfType<LevelTimer>().timerRunning = false;
    public Text countdownDisplay1;
    public Text countdownDisplay2;
    


    void Start(){
        StartCoroutine(CountdownToEnd());
        Debug.Log("LOGTHAT Entered Scene. Remaining time " + startTimeMinutes);
    }

    IEnumerator CountdownToEnd()
    {
        startTimeMinutes -=1;
        if (timerRunning)
        {
             countdownDisplay1.text = startTimeMinutes.ToString();
        }

        startTimeSeconds = 59;

            while ( startTimeSeconds >-2)
            {   
                if (startTimeMinutes == 0 & startTimeSeconds == 30 &timerRunning)
                {
                    countdownDisplay1.color = Color.red;
                    countdownDisplay2.color = Color.red;
                    //add warning sound
                }
                if (startTimeSeconds == -1 & startTimeMinutes != 0)
                {
                    startTimeMinutes --;
                    countdownDisplay1.text = startTimeMinutes.ToString();
                    startTimeSeconds = 59;
                }
                if(timerRunning)
                {
                    countdownDisplay2.text = startTimeSeconds.ToString();
                }
                
                yield return new WaitForSeconds(1f);
                startTimeSeconds --;
            }
        }
    }

