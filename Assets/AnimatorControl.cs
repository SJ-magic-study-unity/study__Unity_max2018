using UnityEngine;
using System.Collections;

public class AnimatorControl : MonoBehaviour {
	enum STATE{
		STATE_BODY,
		STATE_ARM
	}
	
	STATE State = STATE.STATE_BODY;
	Animator animator;
	
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			switch(State){
				case STATE.STATE_BODY:
					State = STATE.STATE_ARM;
					animator.SetInteger("State", 1);
					break;
					
				case STATE.STATE_ARM:
					State = STATE.STATE_BODY;
					animator.SetInteger("State", 0);
					break;
			}
		}
	}
}
