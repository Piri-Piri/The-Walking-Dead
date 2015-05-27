using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent (typeof (Health))]
public class Attacker : MonoBehaviour {

	
	private float currentSpeed;
	private GameObject currentTarget;
	private float health;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		
		// return to walking when defender is down
		if (!currentTarget) {
			anim.SetBool ("isAttacking", false);
		}
	}
	
	
	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log(name + " has been triggered by " +collider.name + "!");
	}
	
	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}
	
	public void StrikeCurrentTarget (float damage) {
		Debug.Log(name + " has attack " + currentTarget + " with damage: " + damage);
		if (currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			if (health) {
				health.DealDamage(damage);
			}
		}
	}
	
	public void Attack (GameObject target) {
		currentTarget = target;
	}
	
}
