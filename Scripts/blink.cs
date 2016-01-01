using UnityEngine;
using System.Collections;

public class blink : MonoBehaviour {

	void Start () {
		StartCoroutine(DoBlinks(3f, 0.2f));
	}
	
	IEnumerator DoBlinks(float duration, float blinkTime) {
		while (duration > 0f) {
			duration -= Time.deltaTime;
			
			//toggle renderer
			renderer.enabled = !renderer.enabled;
			
			//wait for a bit
			yield return new WaitForSeconds(blinkTime);
		}
		
		//make sure renderer is enabled when we exit
		renderer.enabled = true;
	}
}
