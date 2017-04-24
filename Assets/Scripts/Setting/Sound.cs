using UnityEngine;
using System.Collections;
using System;

public class Sound : MonoBehaviour {
	
	public Sprite soundOn;
	public Sprite soundOff;
	private bool isSound = true;

	void Awake(){
		if (PlayerPrefs.GetInt ("sound") == 1) {
			GetComponent<SpriteRenderer>().sprite = soundOn;
		} else {
			GetComponent<SpriteRenderer>().sprite = soundOff;
		}
	}
	
	void OnMouseDown() {
		if (isSound) {
			isSound = false;
			GetComponent<SpriteRenderer>().sprite = soundOff;
			TurnOff();
		} else {
			isSound = true;
			GetComponent<SpriteRenderer>().sprite = soundOn;
			TurnOn();
		}
		Mp3Manager.instance.SoundTurnOn ();
	}

	void TurnOn(){
		PlayerPrefs.SetInt("sound", 1);
		Mp3Manager.instance.SoundTurnOn ();
	}

	void TurnOff(){
		PlayerPrefs.SetInt("sound", 0);
		Mp3Manager.instance.SoundTurnOff ();
	}
}
