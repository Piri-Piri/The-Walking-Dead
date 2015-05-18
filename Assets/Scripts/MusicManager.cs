using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource audioSource;
	
	void Awake () {
		DontDestroyOnLoad (gameObject);
		audioSource = GetComponent<AudioSource>();
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	public void SetVolume (float volume) {
		audioSource.volume = volume;	
	}
	
	void OnLevelWasLoaded () {
		AudioClip currentLevelMusicClip = levelMusicChangeArray[Application.loadedLevel];
		if (currentLevelMusicClip) {
			audioSource.clip = currentLevelMusicClip;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
