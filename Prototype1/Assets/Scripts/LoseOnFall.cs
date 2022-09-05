/*
 * Devun Schneider
 * Prototype 1
 * Checks if player falls off road, if yes, sets gameOver to true
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
