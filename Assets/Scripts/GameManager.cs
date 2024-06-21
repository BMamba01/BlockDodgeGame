using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    public GameObject gameName;
    public GameObject start;
    public TextMeshProUGUI score;
    int scores = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            startSpawning();
            gameStarted = true;
            start.SetActive(false);
            gameName.SetActive(false);
        }
    }
    void startSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }
    void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity);

        scores ++;

        score.text = scores.ToString();
    }
}
