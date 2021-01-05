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
    [SerializeField] AudioClip bgmClip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart()
    {
        timeCounter.SetActiveText(false);
        yield return new WaitForSeconds(1f);
        var audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioSource.clip);
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

        audioSource.clip = bgmClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
