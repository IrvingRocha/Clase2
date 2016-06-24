using UnityEngine;
using System.Collections;

public class FirstPersonCamaeaController : MonoBehaviour {

	public float speedRotation = 50f;
	float angulo=0f;

	void Update ()
	{

		angulo += Input.GetAxis("Mouse Y") * Time.deltaTime*speedRotation;
		angulo = Mathf.Clamp (angulo, -60f, 60f);
		transform.localEulerAngles = new Vector3 (-angulo,
			transform.localEulerAngles.y + Input.GetAxis ("Mouse X") * Time.deltaTime * speedRotation,
			0);

		StartCoroutine ("WaitForPause");
	}

	IEnumerator WaitForPause(){
		yield return new WaitForSeconds (5.0f);
	}

}