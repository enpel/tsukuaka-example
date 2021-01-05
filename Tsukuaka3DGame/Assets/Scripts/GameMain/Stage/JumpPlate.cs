using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.IsPlayerObject())
        {
            other.gameObject.GetComponent<Rigidbody>()?.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
