using UnityEngine;

public class DragonAI : MonoBehaviour {
    GameObject player;
    DragonAnimator dragonAnimator;
	Rigidbody rigidbody;
	
	public enum State {
		Running, Dead
	}
	State state = State.Running;

	void Start () {
		dragonAnimator = GetComponent<DragonAnimator>();
		rigidbody = GetComponent<Rigidbody>();
	    player = GameObject.FindGameObjectWithTag("Player");
	    

	}
	void Update () {		
		switch (state) {
			case State.Running:
				RunToPlayer();
				AttackPlayerifCloseEnough();
				break;
			case State.Dead:
				break;
		}	
	}
	void RunToPlayer() {
		dragonAnimator.PlayRunAnimation();
		transform.LookAt(player.transform);
		rigidbody.velocity = transform.forward * 5;
	}
	void AttackPlayerifCloseEnough() {
		if (Vector3.Distance(transform.position, player.transform.position) < 10) {
	        dragonAnimator.PlayAttackAnimation();
            EndGameUi.ShowTextAndQuit("YOU DIED");
        }
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Trap") {
			dragonAnimator.PlayDeadAnimation();
			state = State.Dead;
		}
	}
}
