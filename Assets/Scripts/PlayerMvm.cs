using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMvm : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rigidbody;
    
    private Vector2 moveDirection;

    // Update is called once per frame
    
    void Update()
    {
        ProcessInputs();
        // AudioManager.instance.Play("game");
    }

    void FixedUpdate()
    {   
        
        Move();

        
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;
    }

    void Move()
    {   
        
        rigidbody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        AudioManager.instance.Play("Walk");
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Zombie_Normal"){
            AudioManager.instance.Play("GameOver");
            SceneManager.LoadScene("GameOverScene");
    }
    }
}
