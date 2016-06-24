﻿using UnityEngine;
using System.Collections;

public class PlayerCharacterController : MonoBehaviour {
	public float speedMovement = 10f;
	public float runMovement = 5f;
	public float jump = 2f;
	private CharacterController character;
	private Vector3 vectorMovement;
	void Start () {
		character = GetComponent<CharacterController> ();
	}

	void Update () {
		vectorMovement = Vector3.zero;

		if (Input.GetKey(KeyCode.Space) && (Input.GetAxis ("Horizontal")!=0 ||Input.GetAxis ("Vertical")!=0))
		{
			if (!character.isGrounded) 
				vectorMovement.y -= 0.1f;
			vectorMovement.x = Input.GetAxis ("Horizontal") * Time.deltaTime * (speedMovement + runMovement);
			vectorMovement.z = Input.GetAxis ("Vertical") * Time.deltaTime * (speedMovement + runMovement);
			character.Move (vectorMovement);

		} else {
			if (!character.isGrounded)
				vectorMovement.y -= 0.1f;
			vectorMovement.x = Input.GetAxis ("Horizontal") * Time.deltaTime * speedMovement;
			vectorMovement.z = Input.GetAxis ("Vertical") * Time.deltaTime * speedMovement;
			character.Move (vectorMovement);
		}
		StartCoroutine ("WaitForPause");

		if (Input.GetKeyDown (KeyCode.J)) {
			if (!character.isGrounded)
				vectorMovement.y -= 0.1f;
			vectorMovement.y = Time.deltaTime * speedMovement * jump;
			character.Move (vectorMovement);
			Debug.Log ("Brincando");
		}
		//Debug.Log (vectorMovement.x);
	}

	IEnumerator WaitForPause(){
		yield return new WaitForSeconds (5.0f);
	}

	void OnControllerColliderHit(ControllerColliderHit colliderHit){
        if (colliderHit.transform.name == "Cube")
        {
            //(GetComponent<MeshRenderer> ().material.color = Color.blue;
            colliderHit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            colliderHit.rigidbody.AddForce(transform.forward * 200f, ForceMode.Impulse);
        }
        }
}
