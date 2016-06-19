using UnityEngine;
using System.Collections;

public class BugFlip : MonoBehaviour {

	public bool facingRight = true;
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow) && facingRight) {
			Flip ();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && !facingRight) {
			Flip ();
		}
	}

	void Flip() {
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
