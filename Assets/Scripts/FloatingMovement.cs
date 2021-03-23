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

// The following class represents the concept of an in-game object's movement and contains a function that simulates the act of an object floating up and down within an interval. 

public class FloatingMovement : MonoBehaviour
{
    private float floatingTimer = 0f;
    public float floatingMax = 1f;
    public float floatingDir = 0.01f;

    private void FixedUpdate()
    {
        if (floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x, 
                transform.position.y + (Time.fixedDeltaTime * floatingDir));
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }
}
