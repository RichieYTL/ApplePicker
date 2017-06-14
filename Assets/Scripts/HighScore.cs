using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

	static public int score = 1000;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHigherScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }
    // Update is called once per frame
    void Update () {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score: " + score;

        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
	}

}
