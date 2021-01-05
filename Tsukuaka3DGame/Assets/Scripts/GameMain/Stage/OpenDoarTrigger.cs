using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoarTrigger : MonoBehaviour
{
    [SerializeField] Doar doar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.IsPlayerObject())
        {
            doar.Open();
        }
    }
}
