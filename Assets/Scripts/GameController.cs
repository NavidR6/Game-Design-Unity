﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Variables that control spawning waves
    [Header("Wave Settings")]
    public GameObject hazard;   // What we are spawning
    public Vector2 spawnValue;  // Where we are spawning
    public int hazardCount;     // How many hazards we are spawning

    [Header("Wave Time Settings")]
    public float startWait;     // How long until first wave
    public float spawnWait;     // How long between each hazard in a wave
    public float waveWait;      // How long between each wave

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Coroutine to spawn waves of hazards
    IEnumerator SpawnWaves()
    {
        // Initial delay before the first wave
        yield return new WaitForSeconds(startWait);

        // Start spawning the waves
        while (true)
        {
            // Spawn some hazards
            for (int i = 0; i < hazardCount; i++)
            {
                // Spawn a single hazard
                Vector2 spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));

                Instantiate(hazard, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait); // Wait for the next hazard
                
            }

            yield return new WaitForSeconds(waveWait);  // Wait for the next wave of hazards

            if(RoundText.roundNumber <= 3)
            {
                hazardCount = 8;
            }
            else if(RoundText.roundNumber <= 7)
            {
                hazardCount = 16;
            }
            else if (RoundText.roundNumber <= 12)
            {
                hazardCount = 24;
            }
            else if (RoundText.roundNumber <= 17)
            {
                hazardCount += 3;
            }

            RoundText.roundNumber += 1;
        }
    }
}
