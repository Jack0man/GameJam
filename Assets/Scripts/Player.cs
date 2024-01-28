using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
	private bool attacking = false;
	[SerializeField] private float playerHealth = 100f;
	[SerializeField] private float timetoAtack = 0.25f;
	[SerializeField] private float timer = 0f;
	[SerializeField] private GameObject attackArea =default;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

	void Start()
	{
		attackArea = transform.GetChild(0).gameObject;
	}
    private void Update()
    {
		if(Input.GetKeyDown(KeyCode.E))
		{	
			animator.SetBool("isAtacking",true);
			Debug.LogError("Attack");
		}
		else
		{	
			animator.SetBool("isAtacking",false);
		}
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
		animator.SetFloat("speed", Mathf.Abs(horizontal));
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
			animator.SetBool("isJumping",true);
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
		else
		{
			animator.SetBool("isJumping",false);
		}

        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
        {	
			
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
}
