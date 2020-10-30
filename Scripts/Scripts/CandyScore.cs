using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CandyScore : MonoBehaviour
{
    public static CandyScore obj;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(obj == null) //if obj doesnt exist
	    {
	        obj = this; //instantiate it
	    }
    }

    public void UpdateScore(int candyValue) 
    {
    	score += candyValue; //takes in the candy value and adds it to score
    	text.text = "Score: " + score.ToString(); //updates the display for score
    }
}
