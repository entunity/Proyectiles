using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotar : MonoBehaviour {

    [SerializeField] int radioExplosion=3;
	// Use this for initialization
	void Start () {
        Invoke("explotar", 2f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void explotar() {
        //this.GetComponent<Rigidbody>().AddExplosionForce(200, this.transform.position, 20f);
        Collider[] cosas = Physics.OverlapSphere(this.transform.position, radioExplosion);
        foreach(var cosa in cosas) {
            if (cosa.tag == "Respawn") {
                //cosa.GetComponent<Rigidbody>().AddRelativeForce(100, 100, 100);
                cosa.GetComponent<Rigidbody>().AddExplosionForce(200, this.transform.position, 20f);
                Debug.Log(cosa.gameObject.name);
            }
        }
        Destroy(this.gameObject);
    }
}
