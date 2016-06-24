using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	public Rigidbody cubeRigidbody;

	void Start () {
		cubeRigidbody = GetComponent<Rigidbody>();
	}


    void OnCollisionEnter(Collision collisionObject)
    {
        if (collisionObject.transform.tag == "CamaraController")
            GetComponent<MeshRenderer>().material.color = Color.red;

    }

	void OnCollisionExit(Collision collisionObject){
		if(collisionObject.transform.tag == "CamaraController")
		GetComponent<MeshRenderer> ().material.color = Color.white;
	}

	void OnCollisionStay(Collision collisionObject){
		if(collisionObject.transform.tag == "CamaraController")
			GetComponent<MeshRenderer> ().material.color = Color.blue;
	}

	void OnControllerColliderHit(ControllerColliderHit colliderHit){
		if(colliderHit.transform.tag == "CamaraController")
			GetComponent<MeshRenderer> ().material.color = Color.blue;
	}
}
