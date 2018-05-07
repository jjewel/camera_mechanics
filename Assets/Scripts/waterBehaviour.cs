using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterBehaviour : MonoBehaviour {
    
    public float bobAmount = 3f;
    private float initialHeight;
    
	// Use this for initialization
	void Start () {
        initialHeight = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 waterObject = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
  

        float updateHeight = Mathf.Sin(Time.time) * bobAmount;
        //Debug.Log(updateHeight);

        this.transform.position = new Vector3(this.transform.position.x, initialHeight + updateHeight, this.transform.position.z);
    }
}
