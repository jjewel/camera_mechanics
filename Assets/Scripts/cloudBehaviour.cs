using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudBehaviour : MonoBehaviour {

    public float cloudSpeed = 2f;
    public float screenMin = -10f;
    public float screenMax = 10f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float currentX = this.transform.position.x;

        float updateX = currentX - (cloudSpeed * Time.deltaTime);

        if(updateX < screenMin)
        {
            updateX = screenMax;
        }
        

        this.transform.position = new Vector3(updateX, this.transform.position.y, this.transform.position.z);


	}
}
