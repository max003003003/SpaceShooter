using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public float fireRate;
    public float nextFire;

    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {            

           nextFire = Time.time + fireRate;
            
    
           Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            if (GameControl.fire3Way)
            {
                Instantiate(shot, new Vector3(shotSpawn.position.x + 1.5f, shotSpawn.position.y, shotSpawn.position.z), shotSpawn.rotation);
                Instantiate(shot, new Vector3(shotSpawn.position.x - 1.5f, shotSpawn.position.y, shotSpawn.position.z), shotSpawn.rotation);
            }
            //Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical,0.0f);

        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.zMin, boundary.zMax),
            0.0f
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }
    

}