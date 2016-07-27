using UnityEngine;
using System.Collections;

public class moveTowardsPlayer : MonoBehaviour {

	GameObject player;
	public float speed = -1f;
	Vector3 TowardPlayer;
	Rigidbody2D ourRigidBody;
	float csquared;
	float c;
	// Use this for initialization
	void Start () {
		ourRigidBody = GetComponent<Rigidbody2D> ();
		player = GameObject.FindWithTag ("Player");

		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		csquared = (transform.position.x - player.transform.position.x) * (transform.position.x - player.transform.position.x) + (transform.position.y - player.transform.position.y) * (transform.position.y - player.transform.position.y);
		c = Mathf.Sqrt (csquared);
		TowardPlayer=new Vector3((transform.position.x - player.transform.position.x)/c,(transform.position.y - player.transform.position.y)/c,0);
		ourRigidBody.velocity = speed * TowardPlayer;
		
		
	
	}
}
