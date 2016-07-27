using UnityEngine;
using System.Collections;

public class controllertest : MonoBehaviour {

	public float moveSpeed = 5f;
	Vector2 moveVector = new Vector2(0f, 0f);
	Rigidbody2D myRigidbody;
	Transform player;
	Vector3 lineFromPlayerToCursor;

	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		player = GetComponent<Transform> ();


	}

	// Update is called once per frame
	void Update () {
		//transform.eulerAngles = Vector3.zero;
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		moveVector = new Vector2( horizontal, vertical );
		if ( moveVector.magnitude > 1f ) {
			moveVector = moveVector.normalized; // better way of normalization
		}
//		Vector3 cursorWorldPos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
//		player.transform.up = cursorWorldPos - player.transform.position;
		Vector3 cursorWorldPos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		cursorWorldPos.z = 0f;
		lineFromPlayerToCursor = cursorWorldPos - player.transform.position;
		player.transform.up = lineFromPlayerToCursor;


	}


	void FixedUpdate () {
		myRigidbody.velocity = moveVector * moveSpeed;
	}

	public Vector3 getdirection(){
		return lineFromPlayerToCursor;
	}
}