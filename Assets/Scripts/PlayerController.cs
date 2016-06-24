﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speedTranslation;
	public float runTranslation;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space) && (Input.GetAxis ("Horizontal")!=0 ||Input.GetAxis ("Vertical")!=0)){
			//transform.Translate (transform.forward * Input.GetAxis("Vertical")* Time.deltaTime*speedTranslation*runTranslation);
			//transform.Translate (transform.right * Input.GetAxis("Horizontal")* Time.deltaTime*speedTranslation*runTranslation);
			transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime *  runTranslation, 0,
				Input.GetAxis ("Vertical") * Time.deltaTime  * runTranslation);
			//Input.GetAxis()//Mapea las flechas Horizontal, vertical; y ocupa a,w,d,s en el sistema local
			Debug.Log("Rapido");
		}
		else{
			//transform.Translate (transform.forward * Input.GetAxis("Vertical")* Time.deltaTime*speedTranslation);
			//transform.Translate (transform.right * Input.GetAxis("Horizontal")* Time.deltaTime*speedTranslation);
			//Input.GetAxis()//Mapea las flechas Horizontal, vertical; y ocupa a,w,d,s en el sistema local
			transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speedTranslation, 0,
				Input.GetAxis ("Vertical") * Time.deltaTime * speedTranslation);
		}
	}
}
