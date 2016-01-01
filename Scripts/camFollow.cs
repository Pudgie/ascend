using UnityEngine;
using System.Collections;

public class camFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void LateUpdate () {
		// transform.position = new Vector3(player.transform.position.x, player.transform.position.y, zPosition);
		Vector3 pos = transform.position;
		// pos.x = player.transform.position.x;
		pos.y = player.transform.position.y + 2;
		transform.position = pos;
	}	
}
