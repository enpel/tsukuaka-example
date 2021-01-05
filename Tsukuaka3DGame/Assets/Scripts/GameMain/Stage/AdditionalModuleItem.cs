using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalModuleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.IsPlayerObject())
        {
            var playerController = other.GetComponent<PlayerController>();
            var jumpModule = other.gameObject.AddComponent<MultipleJump>();
            playerController.SetJumpModule(jumpModule);
            Destroy(this.gameObject);
        }
    }
}
