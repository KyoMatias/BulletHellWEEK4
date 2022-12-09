using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  Movement.cs
//  Movement Script
//
//  Created by Kyo Matias on 12/09/2022.
//  Copyright © 2022 Kyo Matias & Nate Florendo. All rights reserved.
//
public class Movement : MonoBehaviour
{
    //Default Parameters for the ship behaviour
    private float _moveSpeed;
    private bool _moveRight;
    
    // Start is called before the first frame update
    void Start()
    {
        //Sets values at start
        _moveSpeed = 2f;
        _moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 7f)// If the ship is on the right side of the frame.
        {
            _moveRight = false; //stops the ship at 7f
        }
        else if (transform.position.x < 7f)// If the ship is on the left side of the frame.
        {
            _moveRight = true;// Stops the ship at -7f
        }

        if (_moveRight)// Updates the x position of the ship on update
        {
            transform.position = new Vector2(transform.position.x + _moveSpeed * Time.deltaTime, transform.position.y);// Moves the ship to the right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - _moveSpeed * Time.deltaTime, transform.position.y);// Moves the ship to the left.
        }
        
    }
}
