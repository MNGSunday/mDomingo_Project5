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

// The following class simulates the concept of a potion within a game and contains functions to simulate the behavior of said potion when picked up by the player.

public class PotionController : MonoBehaviour
{
    public enum PotionType
    {
        Speed,
        Jump
    }

    public PotionType potionType;
    public int potionModAmount = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (potionType == PotionType.Jump)
            {
                collision.gameObject.GetComponent<PlayerMovement>().hasJumpPotion = true;
            }
            else if (potionType == PotionType.Speed)
            {
                collision.gameObject.GetComponent<PlayerMovement>().hasSpeedPotion = true;
            }

            collision.gameObject.GetComponent<PlayerMovement>().potionModAmount = potionModAmount;

            Destroy(this.gameObject);
        }
    }
}
