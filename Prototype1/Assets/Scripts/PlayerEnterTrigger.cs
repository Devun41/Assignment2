/*
 * Devun Schneider
 * Prototype 1
 * Adds to score if player object passes trigger zones
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attatch this to player
public class PlayerEnterTrigger : MonoBehaviour
{
    //set this reference in the inspector
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            //set the textbox text to You Win!
            ScoreManager.score++;
        }
    }
}
