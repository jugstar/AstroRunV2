using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody rb;
    private Vector3 forwardMovement;
    private Vector3 leftMovement;
    private Vector3 rightMovement;
    public float speed = 15f;
    public float sideSpeed = 35f;
    public float jumpForce = 20;
    bool alive = true;
    [SerializeField] LayerMask groundMask;
    private float maxJumpHeight = 2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y < -5)
        {
            Die();
        }
    }


    //FixedUpdate is called at measured intervals. FixedUpdate used for physics functions
    private void FixedUpdate()
    {
        if (!alive) return;
        forwardMovement = transform.forward * speed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMovement);
        // Uncomment the below lines if keyboard input is to be used.
        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            moveRight();
        } 
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            jump();
        }*/
    }

    public void moveLeft()
    {

        leftMovement = transform.right * sideSpeed * Time.deltaTime;
        rb.MovePosition(rb.position - leftMovement);
    }

    public void moveRight()
    {

        rightMovement = transform.right * sideSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + rightMovement);
    }

    public void jump()
    {
        if (transform.position.y < maxJumpHeight)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void Die()
    {
        alive = false;
        // Restart the game
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*Function detects if we collide with obstacle
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Collision Detected." +other.name);
        
        if (other.gameObject.name == "Obstacle(Clone)") {
            SceneManager.LoadScene("Game");
        }
    }*/

}