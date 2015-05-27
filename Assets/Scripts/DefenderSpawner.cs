using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;

	private GameObject defenderParent;
	
	void Start () {
		defenderParent = GameObject.Find ("Defenders");
		if (!defenderParent) {
			defenderParent = new GameObject("Defenders");
		}
	}

	void OnMouseDown () {
		Vector2 targetPos = SnapToGrid (CalculateWorldPointOfMousePosition ());
		if (Button.selectedDefender) {
			GameObject defender = Instantiate(Button.selectedDefender, targetPos, Quaternion.identity) as GameObject;
			defender.transform.parent = defenderParent.transform;
		}

	}

	Vector2 CalculateWorldPointOfMousePosition () {
		// distance is uninportant in 2D Games with orthograhic camera
		float distanceFromCamera = 10f;

		Vector3 weirdTriplet = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint (weirdTriplet);

		return worldPos;
	}

	Vector2 SnapToGrid (Vector2 rawWorldPos) {
		return new Vector2(Mathf.Round(rawWorldPos.x), Mathf.Round(rawWorldPos.y));
	}
}
