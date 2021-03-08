using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    private bool gameOver = false;

    public Player player;
    public Guard guard;

    public Animator animator;
    public Rigidbody2D isplayer;
    
    
    void Update() {
        if(Input.GetKey("space")) 
            isplayer.MovePosition(isplayer.position + Vector2.right * 10f * Time.deltaTime);
        }
    public void EndGame() {
        if(gameOver){
            return;
        }

        animator.SetTrigger("EndGame");
        gameOver = true;
        player.enabled = false;
    }

}
