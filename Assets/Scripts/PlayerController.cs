using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movementSpeed;
    private float inputHorizontal;
    private Animator playerAnimator;
    public float jumpForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerLateral();
        jump();
    }

    private void movePlayerLateral()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movementSpeed * inputHorizontal, rb.linearVelocityY);
        if (inputHorizontal != 0)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }
    }

    private void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.SetBool("isWalking", false);
            playerAnimator.SetBool("isJumping", true);
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerAnimator.SetBool("isJumping", false);
        }
    }
}
