using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Animator playerAnim;
    public float forceMultiplier;
    public float gravityMultiplier;
    public bool onGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround && !gameOver)
        {
            playerRigidbody.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse);
            onGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("GameOver!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }

        else if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
