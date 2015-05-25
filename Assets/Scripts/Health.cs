using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100f;

	//private Animator anim;
		
	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator>();
	}
	
	
	public void DealDamage(float damage) {
		health -= damage;
		if (health <= 0) {
			// Optionally trigger a death annimation and 
			// evaluted DestroyObject by an AnimationEvent
			// anim...
			DestroyObject ();
		}
	}
	
	public void DestroyObject () {
		Destroy (gameObject);
	}
}
