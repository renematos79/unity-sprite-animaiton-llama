using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Speed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (new Vector2 (this.Speed * Time.deltaTime, 0));	
			var scale = this.gameObject.transform.localScale;
			if (scale.x < 0) {
				scale.x *= -1;	
				this.gameObject.transform.localScale = scale;
			}
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate (new Vector2 (-1 * this.Speed * Time.deltaTime, 0));	
			var scale = this.gameObject.transform.localScale;
			if (scale.x > 0) {
				scale.x *= -1;	
				this.gameObject.transform.localScale = scale;
			}
		}
	}
}
