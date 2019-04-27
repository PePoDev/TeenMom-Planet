using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
	public float speed;
	public bool isControlable { get; set; } = true;

	private Vector2 direction;
	private SpriteRenderer sprite;
	private Rigidbody2D rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (isControlable)
		{
			direction.x = Input.GetAxis("Horizontal");
			direction.y = Input.GetAxis("Vertical");

			if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
			{
				sprite.flipX = true;
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
			{
				sprite.flipX = false;
			}

			var newSpeed = speed;
			if (Input.GetKey(KeyCode.LeftShift))
			{
				newSpeed *= 3f;
			}

			rigid.velocity = direction * newSpeed;
		}
		else
		{
			rigid.velocity = Vector2.zero;
		}
	}
}
