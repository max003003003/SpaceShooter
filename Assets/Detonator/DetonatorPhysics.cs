using UnityEngine;
using System.Collections;

public class DetonatorPhysics : MonoBehaviour {

    public float radius;
    public float power;
    public float size;

    public float delay = 0.1f;

	// Use this for initialization
	void Start () {
        Invoke("Boom", delay);
    }
	
	
	void Boom() {
        Vector3 _explosionPosition = transform.position; //- Vector3.Normalize(MyDetonator().direction);
        Collider[] _colliders = Physics.OverlapSphere(_explosionPosition, radius);

        int i = 0;

        while (i < _colliders.Length)
        {
            Collider hit = _colliders[i];

            if (!hit)
            {
                continue;
            }

            Rigidbody rig = hit.GetComponent<Rigidbody>();

            if (rig)
            {
                //Debug.Log("Hit Name " + hit.name);

                //align the force along the object's rotation
                //this is wrong - need to attenuate the velocity according to distance from the explosion center			
                //offsetting the explosion force position by the negative of the explosion's direction may help
                rig.AddExplosionForce((power * size), _explosionPosition, (radius * size), (4f * 1f * size)); //MyDetonator().upwardsBias * size));

                //fixed 6/15/2013 - didn't work before, was sending message to this script instead :)
                //hit.gameObject.SendMessage("OnDetonatorForceHit", null, SendMessageOptions.DontRequireReceiver);

                //and light them on fire for Rune
                /*
                if (fireObject)
                {
                    //check to see if the object already is on fire. being on fire twice is silly
                    if (hit.transform.Find(fireObject.name + "(Clone)"))
                    {
                        return;
                    }

                    _tempFireObject = (Instantiate(fireObject, this.transform.position, this.transform.rotation)) as GameObject;
                    _tempFireObject.transform.parent = hit.transform;
                    _tempFireObject.transform.localPosition = new Vector3(0f, 0f, 0f);
                    if (_tempFireObject.GetComponent<ParticleEmitter>())
                    {
                        _tempFireObject.GetComponent<ParticleEmitter>().emit = true;
                        Destroy(_tempFireObject, fireObjectLife);
                    }
                }
                */

            }
            i++;
        }	
	}
}
