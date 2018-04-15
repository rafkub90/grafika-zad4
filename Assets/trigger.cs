using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trigger : MonoBehaviour {

    public Light lt;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;

    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        lt.color = color0;

        Destroy(this.gameObject);

    }
}
