using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Camera camera;
    public GameObject target;

	// Use this for initialization
	void Start () {
        camera.transform.position = target.transform.position + new Vector3(10, 0, 0);
        camera.transform.rotation = Quaternion.LookRotation((target.transform.position - camera.transform.position).normalized);
	}
	
	// Update is called once per frame
	void Update () {
        camera.transform.position = target.transform.position + new Vector3(10, 0, 0);
        
	}
}
