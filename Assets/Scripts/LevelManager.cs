using UnityEngine;
using System.Collections;
public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start () {
		if (autoLoadNextLevelAfter == 0) {
			//Debug.Log ("Level auto load is disabled for level: " + Application.loadedLevel);
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel (string name) {
		//Debug.Log("Loading Level request for: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest () {
		//Debug.Log("Quit requested");
		Application.Quit(); // Do NOT use it for IOS / Android apps!
	}
	
	public void LoadNextLevel () {
		Application.LoadLevel(Application.loadedLevel + 1);
	}

}