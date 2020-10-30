using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public int candyValue = 100; //temporary value for Candy. Can modify later

    private void OnTriggerEnter2D(Collider2D other) //if Candy object collides with 
    {
	     if(other.gameObject.CompareTag("Player")) //an object tagged Player
	    {
	        CandyScore.obj.UpdateScore(candyValue); //Update the score
            Destroy(this.gameObject); //destroy the candy object
        }
    }


}
