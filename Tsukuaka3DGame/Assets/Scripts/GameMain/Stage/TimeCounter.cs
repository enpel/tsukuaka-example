using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] float limitTime = 30; //秒
    [SerializeField] Text timeText;

    float currentTime = 0;
    bool isPlaying = false;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying) { return; }
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        timeText.text = $"あと{currentTime:#.00}秒";
    }

    public void SetPlaying(bool value)
    {
        isPlaying = value;
    }

    public void SetActiveText(bool value)
    {
        timeText.gameObject.SetActive(value);
    }

}
