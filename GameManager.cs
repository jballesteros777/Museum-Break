using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private bool gameOver = false;

    public Player player;
    
    public Guard guard;

    public Animator animator;
    
    public void EndGame() {
        if(gameOver){
            return;
        }

        animator.SetTrigger("EndGame");
        gameOver = true;
        player.enabled = false;
        
    }

}
