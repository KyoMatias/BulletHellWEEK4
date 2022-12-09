using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  Fire.cs
//  Fire Script
//
//  Created by Kyo Matias on 12/09/2022.
//  Copyright © 2022 Kyo Matias, Nate Florendo. All rights reserved.
//
public class Fire : MonoBehaviour
{
    [SerializeField] 
    private int _bulletsAmounts = 10;

    [SerializeField] 
    private float _startAngle = 90f, _endAngle = 270f;

    private Vector2 _bulletMoveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);
    }

    private void FireA()
    {
        float angleStep = (_endAngle - _startAngle) / _bulletsAmounts;
        float angle = _startAngle;

        for (int i = 0; i < _bulletsAmounts + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.BulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDIrection(bulDir);

            angle += angleStep;
        }
    }
}
