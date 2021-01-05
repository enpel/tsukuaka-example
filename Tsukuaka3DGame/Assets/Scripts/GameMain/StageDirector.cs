using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageDirector : MonoBehaviour
{
    [SerializeField] TimeCounter timeCounter;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Text centerText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart()
    {
        timeCounter.SetActiveText(false);
        yield return new WaitForSeconds(1f);
        centerText.gameObject.SetActive(true);
        centerText.text = "3";
        yield return new WaitForSeconds(1f);
        centerText.text = "2";
        yield return new WaitForSeconds(1f);
        centerText.text = "1";
        GameObject.Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(1f);
        centerText.gameObject.SetActive(false);
        timeCounter.SetPlaying(true);
        timeCounter.SetActiveText(true);
    }
}
