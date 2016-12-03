using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class A52 : MonoBehaviour {

	public AudioClip Nota47;

	AudioSource Audio;
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Audio.clip = Nota47;
			Audio.Play ();
		}

	}
}
