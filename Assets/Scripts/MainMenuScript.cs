using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayButton() {
        // AudioManager.instance.Play("game");
        SceneManager.LoadScene("SampleScene");
    }
}
