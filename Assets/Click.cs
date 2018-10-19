using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDisparo : MonoBehaviour {

    [SerializeField] Transform bomba;
    [SerializeField] GameObject canion;
    private GameObject disparo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            disparo = Instantiate(bomba.gameObject, canion.transform.position, canion.transform.rotation);
            disparo.GetComponent<Rigidbody>().AddRelativeForce(0, 100f, 100f);
            
        }
	}
    
}
