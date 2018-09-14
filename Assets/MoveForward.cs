using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    public float speed = 2;
    Rigidbody rb;
    public GameController gc;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;		
	}

	private void OnCollisionEnter(Collision collision)
    {
        gc.GameOver();
    }
	// Update is called once per frame
	void Update ()
    {
        if (!gc.gameOver)
        {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
            transform.position += Vector3.up * -5f * Time.deltaTime;
            if (Input.GetMouseButton(0))
            {
                transform.position += Vector3.up * 10 * Time.deltaTime;
            }
        }
    }
}
