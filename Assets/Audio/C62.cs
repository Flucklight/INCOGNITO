using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class C62 : MonoBehaviour {

	public AudioClip Nota50;

	AudioSource Audio;
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Audio.clip = Nota50;
			Audio.Play ();
		}

	}
}
