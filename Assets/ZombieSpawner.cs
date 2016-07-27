using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {
	public GameObject zombie;

	public float time=10f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnZombie", 5f, time);
		//zombie = GameObject.FindWithTag ("Zombie");
	
	}

	// Update is called once per frame
	void Update(){
		
		
		
	}

	void SpawnZombie(){
		Instantiate (zombie,transform.position,Quaternion.Euler(Vector3.zero));
	}

}
