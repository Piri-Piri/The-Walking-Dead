using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		
		if (musicManager) {
			float masterVolume = PlayerPrefsManager.GetMasterVolume();
			musicManager.SetVolume(masterVolume);
		} else {
			Debug.LogWarning("Unable to set master volume cause music manager object not found. Script: " + name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
