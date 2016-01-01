using UnityEngine;
using System.Collections;

public class howToPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			Application.LoadLevel ("HowPlay");
		}
		
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Application.LoadLevel ("Scene4");
		}
	}
}
