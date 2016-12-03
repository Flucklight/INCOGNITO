using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class A5 : MonoBehaviour {

	public AudioClip Nota46;

	AudioSource Audio;
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Audio.clip = Nota46;
			Audio.Play ();
		}
		
	}
}
