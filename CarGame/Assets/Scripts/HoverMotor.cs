using UnityEngine;
using System.Collections;

public class HoverMotor : MonoBehaviour {

	public float speed = 90f;
	//public float speed = 10;
	public float turnSpeed = 5f;
	//public float hoverForce = 65f;
	//public float hoverHeight = 3.5f;
	private float powerInput;
	private float turnInput;
	private Rigidbody carRigidbody;


	void Awake () 
	{
		carRigidbody = GetComponent <Rigidbody>();
	}

	void Update () 
	{
		//powerInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");

		transform.Rotate(new Vector3(0f, Time.deltaTime * turnInput * turnSpeed, 0f));
	}

	void FixedUpdate()
	{
//		Ray ray = new Ray (transform.position, -transform.up);
//		RaycastHit hit;
//
//		if (Physics.Raycast(ray, out hit, hoverHeight))
//		{
//			float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
//			Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverForce;
//			//carRigidbody.AddForce(appliedHoverForce, ForceMode.Acceleration);
//		}

		//carRigidbody.AddRelativeForce(0f, 0f, powerInput * speed);
		//carRigidbody.AddRelativeForce(0f, 0f, (speed * -1f* AumentarVelocidad.vueltas));
		//carRigidbody.AddRelativeForce(0f, 0f, (speed * -1f));
		if (AumentarVelocidad.vueltas == 1f) {
			if (Turbo.turbo == 1f) {
				carRigidbody.AddRelativeForce (0f, 0f, (speed * -1f));
			} else {
				carRigidbody.AddRelativeForce (0f, 0f, (speed + speed*0.5f )*-1f);
			}
		} else {
			if (Turbo.turbo == 1f) {
				carRigidbody.AddRelativeForce (0f, 0f, (speed + AumentarVelocidad.vueltas * 0.1f) * -1f);
			} else {
				carRigidbody.AddRelativeForce (0f, 0f, (speed + AumentarVelocidad.vueltas * 0.1f +speed*0.5f )*-1f);
			}

		}
	}
}