using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    float x, y;

	// Use this for initialization
	void Start () {
        x = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mo = new Vector3(x + 1, 0, 0);
        this.transform.Translate(mo);
        x = this.transform.position.x;
	}
}
