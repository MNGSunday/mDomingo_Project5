/*
Name: Marc Domingo
Student ID: 2346778
Chapman Email: mdomingo@chapman.edu
Course Number and Section: 236-03
Assignment: Project 5
This is my own work, and I did not cheat on this assignment.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The following class represents the concept of an in-game collectible and contains functions to simulate the act of picking up said collectible.

public class GemstonePickup : MonoBehaviour
{
    public AudioClip pickupClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupClip, transform.position);
            Destroy(this.gameObject);
        }
    }
}
