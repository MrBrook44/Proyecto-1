using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform trnFollow;
    private Transform trn;
	void Start () {
        trn = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        trn.position = new Vector3(trnFollow.position.x, trnFollow.position.y,trn.position.z);
	}
}
