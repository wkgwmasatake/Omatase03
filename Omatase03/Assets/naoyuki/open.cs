using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour {
    float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time >= 1.0f)
        {
            transform.position += new Vector3(0.0f, 2.0f, 0.0f);
        }
	}
}
