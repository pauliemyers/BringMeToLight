using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
	public float speed;

	public Vector3 jump;
	public float jumpForce = 6.0f;
	public float jumpHeight = 2.0f;

	private bool isGrounded;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		jump = new Vector3 (0.0f, jumpHeight, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed, 0, 0);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-speed, 0, 0);
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, speed);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, 0, -speed);
		}

		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {

			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
	}

	void OnCollisionStay() {
		isGrounded = true;
	}
}

