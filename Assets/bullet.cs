using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	public float speed;
	Vector3 mouseposition;
	Vector3 direction;
	Vector3 unitdirection;
	Vector3 TowardsMouse;
	float xdirec;
	float ydirec;
	float csquared;
	float c;
	public GameObject player;
	Rigidbody2D ourrigidbody;

	// Use this for initialization
	void Start () {
		ourrigidbody = GetComponent<Rigidbody2D> ();
		direction=player.GetComponent<controllertest> ().getdirection ();
		xdirec = direction.x - transform.position.x;
		ydirec = direction.y - transform.position.y;
		csquared = (xdirec) * (xdirec) + (ydirec) * (ydirec);
		c = Mathf.Sqrt (csquared);
		unitdirection = new Vector3 (xdirec / c, ydirec / c, 0);


		//direction=new Vector3(xdirec/c,ydirec/c,0);
		TowardsMouse = speed * direction;
		ourrigidbody = GetComponent<Rigidbody2D> ();


		Vector3 cursorWorldPos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		cursorWorldPos.z = 0f;
		Vector3 lineFromPlayerToCursor = cursorWorldPos - transform.position;
		transform.up = lineFromPlayerToCursor;
	
	}
	
	// Update is called once per frame
	void Update () {
		ourrigidbody.velocity = TowardsMouse;
		
	
	}
}
