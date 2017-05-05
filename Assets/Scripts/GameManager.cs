using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	private int selectedZombiePostion = 0;
	public GameObject selectedZombie;
	public List<GameObject> zombies; 

	public Vector3 selectedSize;
	public Vector3 defaultSize; 

	// Use this for initialization
	void Start () {
		SelectZombie (selectedZombie);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("left")) {
			GetZombieLeft ();
	
		} else if (Input.GetKeyDown ("right")) {
			GetZombieRight ();
		} else if (Input.GetKeyDown ("up")) {
			PushUP ();
		}

	}

	void SelectZombie(GameObject newZombie){

		selectedZombie.transform.localScale = defaultSize;
		selectedZombie = newZombie; 
		 selectedZombie.transform.localScale = selectedSize;

	}

	void GetZombieRight(){
		if (selectedZombiePostion == 3) {
			selectedZombiePostion = 0;
			SelectZombie (zombies [0]);
		} else {

			//GameObject newZombie = zombies[selectedZombiePostion-1];
			selectedZombiePostion = selectedZombiePostion + 1;

			SelectZombie ( zombies[selectedZombiePostion]);
		}
	}



	void GetZombieLeft(){

		if (selectedZombiePostion == 0) {
			selectedZombiePostion = 3;
			SelectZombie (zombies [3]);
		} else {

			//GameObject newZombie = zombies[selectedZombiePostion-1];
			selectedZombiePostion = selectedZombiePostion - 1;

			SelectZombie ( zombies[selectedZombiePostion]);

		}
	}

	void PushUP(){

		Rigidbody Rb = selectedZombie.GetComponent<Rigidbody> ();

		Rb.AddForce (0, 0, 10, ForceMode.Impulse);

	}


}
