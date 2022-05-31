using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour {

    public AudioClip telefono;
    AudioSource fuenteaudio;

	// Use this for initialization
	void Start ()
    {
        fuenteaudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            fuenteaudio.clip = telefono;
            fuenteaudio.Play();
        }
         
	}

}
