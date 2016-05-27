using UnityEngine;
using System.Collections;

public class SpeedParticles : MonoBehaviour {
	
 
	// Use this for initialization
	void Start () {
		 
						
	}
	
	// Update is called once per frame
	void Update () {
	 
				GetComponent<ParticleEmitter>().emit = true;
				Vector3 aux = GetComponent<ParticleEmitter>().localVelocity;
			 
				GetComponent<ParticleEmitter>().localVelocity = aux;
		 
	}
}
