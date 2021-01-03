using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] float limitTime = 30; //秒

    float currentTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
