using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("GameMain");
    }
}
