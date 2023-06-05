using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    //PlayerMovement playerMovement;
    PlayerController playerController;

	private void Start () {
        //playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            // Kill the player
            //playerMovement.Die();
            playerController.Die();
            
        }
    }

    private void Update () {
	
	}
}