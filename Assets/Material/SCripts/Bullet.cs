using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  Bullet.cs
//  Bullet Script
//
//  Created by Kyo Matias on 12/09/2022.
//  Copyright © 2022 Kyo Matias & Nate Florendo. All rights reserved.
//
public class Bullet : MonoBehaviour
{
    private Vector2 _moveDirection;
    private float _moveSpeed;

    private void _onEnable()
    {
        Invoke("Destroy", 3f);
    }

    private void Start()
    {
        _moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_moveDirection *_moveSpeed * Time.deltaTime);
    }

    public void SetMoveDIrection(Vector2 dir)
    {
        _moveDirection = dir;
    }

    private void _destroy()
    {
        gameObject.SetActive(false);
    }

    private void _onDisable()
    {
        CancelInvoke();
    }
}
