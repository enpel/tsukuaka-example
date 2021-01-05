using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitAndDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.IsPlayerObject())
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
