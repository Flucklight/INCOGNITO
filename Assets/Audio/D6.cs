using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class D6 : MonoBehaviour {

	public AudioClip Nota51;

	AudioSource Audio;
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Audio.clip = Nota51;
			Audio.Play ();
		}

	}
}
