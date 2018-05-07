using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleCamera : MonoBehaviour {

    public float xRotInc = 1;
    public float yPosInc = 1;
    public float zPosInc = 1;
    public float fovInc = 1;

    private float xRotate;
    private float yPosition;
    private float zPosition;
    private float fieldOfView;

    private Vector3 posInit;
    private Quaternion rotInit;
    private float fovInit;
    
    
    


	// Use this for initialization
	void Start () {
        posInit = this.transform.position;
        rotInit = this.transform.rotation;
        fovInit = Camera.main.fieldOfView;
       
		
	}
	
	// Update is called once per frame
	void Update () {
        xRotate = this.transform.rotation.x;
        yPosition = this.transform.position.y;
        zPosition = this.transform.position.z;
        fieldOfView = Camera.main.fieldOfView;

        if (Input.GetKey(KeyCode.X)){
            xRotate = xRotate + (xRotInc * Time.deltaTime);
            yPosition = yPosition + (yPosInc * Time.deltaTime);
            zPosition = zPosition - (zPosInc * Time.deltaTime);
            fieldOfView = fieldOfView + (fovInc * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Z)){
            xRotate = xRotate - (xRotInc * Time.deltaTime);
            yPosition = yPosition - (yPosInc * Time.deltaTime);
            zPosition = zPosition + (zPosInc * Time.deltaTime);
            fieldOfView = fieldOfView - (fovInc * Time.deltaTime);
        }
        

        this.transform.rotation = new Quaternion(xRotate, this.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
        this.transform.position = new Vector3(this.transform.position.x, yPosition, zPosition);
        Camera.main.fieldOfView = fieldOfView;

        if (Input.GetKeyDown(KeyCode.C)) {
            this.transform.position = posInit;
            this.transform.rotation = rotInit;
            Camera.main.fieldOfView = fovInit;
        }
    }
}
