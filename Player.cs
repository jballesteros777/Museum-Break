using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    private bool isPlayer = true;

    public Rigidbody2D isplayer;

    public float speed = 10f;
    
    void Update() {
        if(Input.GetKey("space")) 
            isplayer.MovePosition(isplayer.position + Vector2.right * 10f * Time.deltaTime);
        }
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player") {
            isPlayer = false;
        } else if(col.tag == "Light") {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

