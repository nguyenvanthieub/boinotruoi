using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	public Sprite musicOn;
	public Sprite musicOff;
	private bool isMusic = true;

	void Awake(){
		if (PlayerPrefs.GetInt ("music") == 1) {
			GetComponent<SpriteRenderer>().sprite = musicOn;
		} else {
			GetComponent<SpriteRenderer>().sprite = musicOff;
		}
	}

	void OnMouseDown() {
		if (isMusic) {
			isMusic = false;
			GetComponent<SpriteRenderer>().sprite = musicOff;
			TurnOff();
		} else {
			isMusic = true;
			GetComponent<SpriteRenderer>().sprite = musicOn;
			TurnOn();
		}
		Mp3Manager.instance.SoundTurnOn ();
	}

	void TurnOn(){
		PlayerPrefs.SetInt("music", 1);
		Mp3Manager.instance.MusicTurnOn ();
	}
	
	void TurnOff(){
		PlayerPrefs.SetInt("music", 0);
		Mp3Manager.instance.MusicTurnOff ();
	}
}
