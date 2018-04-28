using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lilpump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(70 * Time.deltaTime, 70 * Time.deltaTime, 70 * Time.deltaTime) ;

        
	}
}
