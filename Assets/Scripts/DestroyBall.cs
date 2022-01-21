using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Tree"){
			Destroy (col.gameObject);
		}
	}

}
