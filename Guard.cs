﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

    private bool moveGuard = true;    
    public float speed = 2f;

    void Update() {
        
        if(moveGuard)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        if(transform.position.x >= 10){
            moveGuard = false;
        }

        if(transform.position.x <= 3){
            moveGuard = true;
        }
    }
}
  
