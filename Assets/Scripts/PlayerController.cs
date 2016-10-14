using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;

    public float Speed;

	// Use this for initialization
	void Start ()
	{
	    rigidbody2D = GetComponent<Rigidbody2D>();
	}
	

    void FixedUpdate()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        rigidbody2D.AddForce(new Vector2(moveHorizontal * Speed, moveVertical * Speed));
        
    }


	// Update is called once per frame
	void Update () {
	
	}
}
