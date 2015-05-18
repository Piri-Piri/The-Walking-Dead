using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master volume out of range! Value: " + volume); 
		}
	}
	
	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	
	public static void UnlockLevel (int level) {
		if (level < Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1); // use 1 as true  
		} else {
			Debug.LogError ("Level to unlock is out of range! Level: " + level); 
		}
	} 
	
	public static bool IsLevelUnlocked (int level) {
		bool isLevelUnlocked = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString()) == 1;
		if (level < Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Requested Level is out of range! Level: " + level);
			return false; 
		}
	}
	
	public static void SetDifficulty (float value) {
		if (value >= 1f && value <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, value);
		} else {
			Debug.LogError ("Difficulty out of range! Value: " + value); 
		}	
	}
	
	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
