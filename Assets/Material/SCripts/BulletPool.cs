using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  bulletpool.cs
//  bulelt pool Script
//
//  Created by Kyo Matias on 12/09/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//
public class BulletPool : MonoBehaviour
{
    public static BulletPool BulletPoolInstance;

    [SerializeField] 
    private GameObject _pooledBullet;

    private bool _notEnough;

    private List<GameObject> _bullets;

    private void Awake()
    {
        BulletPoolInstance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _bullets = new List<GameObject>();
    }

    public GameObject GetBullet()
    {
        if (_bullets.Count > 0)
        {
            for (int i = 0; i < _bullets.Count; i++)
            {
                if (!_bullets[i].activeInHierarchy)
                {
                    return _bullets[i];
                }
            }
        }

        if (_notEnough)
        {
            GameObject bul = Instantiate(_pooledBullet);
            bul.SetActive(false);
            _bullets.Add(bul);
            return bul;
        }

        return null;
    }
}
