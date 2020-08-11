using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
	private Vector2 movement;
	
    // Start is called before the first frame update
    void Start()
    {
		mask = false;
    }
	
    // Update is called once per frame
    void Update()
    {
		Move();
    }
	
	// Does the moving
	private void Move()
	{
		movement = movement.normalized * speed * Time.deltaTime;
		transform.Translate(movement);
	}
	
	// Movement input handler
	public void OnMove(InputValue value)
	{
		movement = value.Get<Vector2>();
	}
}