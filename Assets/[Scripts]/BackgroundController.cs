///BackgroundController.cs
/// Jing Yuan Cheng 101257237
/// Last modified: 22/10/2021
/// This script makes background scrolling
/// version history
/// Version 1.1 original file
/// Version 1.2 background is rolling from right to left

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //move the background image back to its designed position
    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f );
    }

    //move the background image horizontally from right to left
    private void _Move()
    {
        transform.position += new Vector3(-verticalSpeed,0.0f ) * Time.deltaTime;
    }

    //check if the background image if it's out of bound
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
