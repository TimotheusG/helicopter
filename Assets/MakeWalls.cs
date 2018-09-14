using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWalls : MonoBehaviour {

    public GameObject player;
    public GameObject lastTop;
    public GameObject lastBottom;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if((lastTop.transform.position.z - player.transform.position.z) < 5)
        {
            var s1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            var s2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            float offset = Random.Range(0,100);
            offset = (offset - 50) / 100;
            s1.transform.position = lastTop.transform.position + new Vector3(0, offset, 1);
            s2.transform.position = lastBottom.transform.position + new Vector3(0, offset, 1);
            lastTop = s1;
            lastBottom = s2;
        }
		
	}
}
