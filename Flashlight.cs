using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
    
    private bool moveLight = true;    
    public float speed = 2f;

    void Update() {
        
        if(moveLight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        if(transform.position.x >= 13){
            moveLight = false;
        }

        if(transform.position.x <= 6){
            moveLight = true;
        }
    }
}