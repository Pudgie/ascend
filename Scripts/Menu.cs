using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			Application.LoadLevel ("Scene4");
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Application.LoadLevel ("HowPlay");
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Application.Quit();
		}
	}
}





//	public string CurrentMenu;
	
	// Use this for initialization
//	void Start () {
//		CurrentMenu = "Main";
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			Application.LoadLevel ("Scene4");
//		}
//	}
//}
//
//
//



//
//	void onGUI ()
//	{

//		if (GUI.Button (new Rect(10, 10, 200, 50), "How To Play"))
//		{
//		}

//		if (GUI.Button (new Rect(10, 10, 200, 50), "Play"))
//		{
//			Application.LoadLevel ("Scene4");
//
//		}
//
//		if (GUI.Button (new Rect(10, 10, 200, 50), "Quit"))
//		{
//			Application.Quit();
//
//		}

//
//
//		if (GUI.Button(new Rect (Screen.width/2.5f, Screen.height/3, Screen.width/5, Screen.height/10), "How To Play"))
//		{
//			Application.LoadLevel ("HowPlay");
//		}

//		if (GUI.Button(new Rect (Screen.width/2.5f, Screen.height/3, Screen.width/5, Screen.height/10), "Play"))
//		{
//			Application.LoadLevel ("Scene4");
//		}
//
//		if (GUI.Button(new Rect (Screen.width/2.5f, Screen.height/2, Screen.width/5, Screen.height/10), "Quit"))
//		{
//			Application.Quit();
//		}

//
//
//	private void menu_main()
//	{
//
//	}
//
//	private void menu_HowPlay()
//	{
//		if (GUI.Button (new Rect(10, 10, 200, 50), "Back"))
//		{
//		}
//	}
//
