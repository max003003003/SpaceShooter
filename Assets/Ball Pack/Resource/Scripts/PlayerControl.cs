/**
 * Controls player based on mouse movement. Static speed value 
 * and no rotation.
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControl : MonoBehaviour
{
    public GameObject orbit;
    public GameObject sim;
	public int maxSpeed = 70;
	public int minSpeed = 10;
	public float rotationSpeed = 50;
	public bool status = false;
	
	public int currrentSpeed = 30;
	private GameObject[] turbines;
	
	void Start(){
		turbines = GameObject.FindGameObjectsWithTag("Turbine");
	}
	
    void LateUpdate()
    {
		//Coordinates pause - play with manager object
		if (status){
            //Rotation manager
            if (Input.GetKey(KeyCode.A))
            {
                //transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
                transform.Translate(0.25f, 0, 0);
                

            }
            else if (Input.GetKey(KeyCode.D))
            {
                // transform.Rotate(0, 0, -Time.deltaTime * rotationSpeed);
                transform.Translate(-0.25f,0, 0 );

            }
			
			//Max speed
			if (Input.GetKey(KeyCode.W)){
				//currrentSpeed = maxSpeed;
				//MaxTurbines(0.65f);
                transform.Translate(0, 0.25f, 0);
            }//Min speed
			else if (Input.GetKey(KeyCode.S)){
                //currrentSpeed = minSpeed;
                //MaxTurbines(0.3f);
                transform.Translate(0, -0.25f, 0);
            }//Cruise speed
			else{
				currrentSpeed = 30;
				MaxTurbines(0.55f);
			}
		/*
			Vector3 mouseMovement = (Input.mousePosition - (new Vector3(Screen.width, Screen.height, 0) / 2.0f)) * 1;
			transform.Rotate(new Vector3(-mouseMovement.y, mouseMovement.x, -mouseMovement.x) * 0.025f);
			transform.Translate(Vector3.forward * Time.deltaTime*currrentSpeed);
            */
		}
    }
	
	void MaxTurbines(float intensity){
		foreach (GameObject turbine in turbines)
        {
            turbine.GetComponent<LensFlare>().brightness = intensity;
        }
	}

}

