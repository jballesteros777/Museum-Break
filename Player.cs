using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    private bool isMove = true;

    public Rigidbody2D rb;
    
    public float speed = 10f;
   
    void Update() {
        if(!isMove){
            rb.MovePosition(rb.position + Vector2.right * speed * Time.deltaTime);
        }
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Guard") {
            isMove = true;
        } else if(col.tag == "Player") {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

