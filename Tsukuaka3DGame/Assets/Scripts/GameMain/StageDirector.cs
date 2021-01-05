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
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource seSource;

    void Start()
    {
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart()
    {
        timeCounter.SetActiveText(false);

        yield return new WaitForSeconds(1f);
        seSource.Play();
        centerText.gameObject.SetActive(true);
        centerText.text = "3";

        yield return new WaitForSeconds(1f);        
        centerText.text = "2";

        yield return new WaitForSeconds(1f);
        centerText.text = "1";

        yield return new WaitForSeconds(1f);
        GameObject.Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);

        centerText.gameObject.SetActive(false);
        timeCounter.SetPlaying(true);
        timeCounter.SetActiveText(true);
        yield return new WaitForSeconds(1f);

        bgmSource.Play();
    }
}
