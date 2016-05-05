using UnityEngine;
using System.Collections;

public class DestroyByBound : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}

