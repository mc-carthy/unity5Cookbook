using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour {

	private Animator animatorController;

	// Use this for initialization
	void Start () {
		animatorController = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			animatorController.SetTrigger ("Attack");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			animatorController.SetTrigger ("Die");
		}
	}
}
