using UnityEngine;
using System.Collections;

public class TutManager : MonoBehaviour {

	public GameObject tut;
	
	public static TutManager Instance;
	
	void Awake(){
		Instance = this;
	}

	public void HideTut(){
		tut.SetActive(false);
	}
	
	public void ViewTut(){
		tut.SetActive(true);
	}
}
