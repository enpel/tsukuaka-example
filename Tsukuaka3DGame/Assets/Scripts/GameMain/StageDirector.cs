using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDirector : MonoBehaviour
{
    [SerializeField] TimeCounter timeCounter;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
