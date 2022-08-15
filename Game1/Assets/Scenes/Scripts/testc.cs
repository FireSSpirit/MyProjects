using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class testc : MonoBehaviour {

	public enum ProjectAxis {onlyX = 0, xAndY = 1};
	public ProjectAxis projectAxis = ProjectAxis.onlyX;
	public float speed = 150f;
	public float jumpForce = 700f;
	public KeyCode leftButton = KeyCode.A;
	public KeyCode rightButton = KeyCode.D;
	public bool isFacingRight = true;
	private Vector3 direction;
	private float vertical;
	private float horizontal;
	private Rigidbody2D body;
	public Transform groundCheck;
	public float groundRadius = 0.82f;
	public LayerMask whatIsGround;
	private bool grounded = false;
	void Start () 
	{
		body = GetComponent<Rigidbody2D>();
		body.freezeRotation = true;	

		if(projectAxis == ProjectAxis.xAndY) 
		{
			body.gravityScale = 0;
			body.drag = 10;
		}
	}
	
	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		body.AddForce(direction * body.mass * speed);

		if(Mathf.Abs(body.velocity.x) > speed/100f)
		{
			body.velocity = new Vector2(Mathf.Sign(body.velocity.x) * speed/100f, body.velocity.y);
		}

		if(projectAxis == ProjectAxis.xAndY)
		{
			if(Mathf.Abs(body.velocity.y) > speed/100f)
			{
				body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y) * speed/100f);
			}
		}
	}

	void Flip()
	{
		if(projectAxis == ProjectAxis.onlyX)
		{
			isFacingRight = !isFacingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
	
	void Update () 
	{
		
if (grounded && (Input.GetKeyDown (KeyCode.W)||Input.GetKeyDown (KeyCode.UpArrow))) {

			GetComponent<Rigidbody2D>().AddForce (new Vector2(0f,jumpForce));
		}


		if(Input.GetKey(leftButton)) horizontal = -1;
		else if(Input.GetKey(rightButton)) horizontal = 1; else horizontal = 0;

		if(projectAxis == ProjectAxis.onlyX) 
		{
			direction = new Vector2(horizontal, 0); 
		}
		else 
		{			
			direction = new Vector2(horizontal, vertical);
		}

		if(horizontal > 0 && !isFacingRight) Flip(); else if(horizontal < 0 && isFacingRight) Flip();
	}
}
