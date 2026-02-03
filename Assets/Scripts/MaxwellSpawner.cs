using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MaxwellSpawner : MonoBehaviour
{
    public GameObject evilMaxwellPrefab;
    public GameObject spawnedMaxwell;
    public List<GameObject> enemies;

    public GameObject victoryScreen;
    public EvilMaxwell maxwellScript;

    Vector2 spawnPos;

    public float maxwellHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5 ; i++)
        {
            spawnPos = Random.insideUnitCircle * 4;

            spawnedMaxwell = Instantiate(evilMaxwellPrefab, spawnPos, Quaternion.identity);
            enemies.Add(spawnedMaxwell);
        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < enemies.Count ; i++)
        {
            maxwellScript = enemies[i].GetComponent<EvilMaxwell>(); 
            maxwellHealth = maxwellScript.health;

            if (maxwellHealth < 1)
            {
                GameObject evilMaxwell = enemies[i];

                enemies.RemoveAt(i);
                Destroy(evilMaxwell);
            }
        }

        if (enemies.Count == 0)
        {
            victoryScreen.SetActive(true);
        }
    }
}
