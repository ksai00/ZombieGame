using UnityEngine;
using System.Collections;

public class deathtrigger : MonoBehaviour {

	// Use this for initialization


	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("colllided");
		if (other.gameObject.tag == "Player") {
			Destroy (other.gameObject);
		}
	
	}
}
