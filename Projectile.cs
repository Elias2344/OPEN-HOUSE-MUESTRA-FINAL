﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float ProjectileSpeed = 0.3f;

    public int maxXPosition = 102;

    public string damagebleTargetTag = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(new Vector2(0.4f, 0f));
        if (transform.position.x > 102){
            Destroy(gameObject);
    }
    }
}

