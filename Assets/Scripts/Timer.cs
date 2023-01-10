using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    public GameOverScreen GameOverScreen;
    public float WaitSec;
    private int WaitSecInt;
    public Text text;

    private void FixedUpdate(){
        if(WaitSec>0)
        {
            WaitSec -= Time.fixedDeltaTime;
            WaitSecInt = (int)WaitSec;
            text.text = WaitSecInt.ToString();
            
        }
        else
        {
            // getting the active scene when time is over
           AudioManager.instance.Play("game");
           SceneManager.LoadScene("GameOverScene"); 
        }
    }
}