using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public int spawnCount;
    public float spawnWait;
    public float startSpawn;
    public float waveWait;
    public TMP_Text scoreText;
    public int score;

    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(startSpawn);
        while (true) //sürekli bu kodu çalıştır
        {
            for (int i = 0; i < spawnCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-3,3),0,10);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                //Coroutine-kodu bekletmek için
                //1.IEnumerator döndürmek zorundadır.
                //2.En az 1 adet yield ifadesi bulundurmak zorundadır.
                //3.Coroutinler çağrılırken mutlaka StartCoroutine metoduyla çağırılmalıdır.
                yield return new WaitForSeconds(spawnWait);
            }

            yield return new WaitForSeconds(waveWait);
        }
    }

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
    void Start()
    {
        StartCoroutine(SpawnValues());
    }

}
