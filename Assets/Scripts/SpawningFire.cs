using System.Collections.Generic;
using UnityEngine;

public class SpawningFire : MonoBehaviour
{
    public GameObject firePrefab;
    public GameObject currentFire;
    public List<GameObject> fires;

    Vector2 spawnPos;

    public float timerValue = 0;
    public float timerMax = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos.x = -10;
        spawnPos.y = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnFire()
    {
        timerValue += Time.deltaTime;

        if(timerValue > timerMax)
        {
            spawnPos.y = 0.5f;
            currentFire = Instantiate(firePrefab, spawnPos, Quaternion.identity);
            fires.Add(currentFire);

            spawnPos.y = -0.5f;
            currentFire = Instantiate(firePrefab, spawnPos, Quaternion.identity);
            fires.Add(currentFire);

            spawnPos.y = -1.5f;
            currentFire = Instantiate(firePrefab, spawnPos, Quaternion.identity);
            fires.Add(currentFire);

            spawnPos.x += 0.5f;
            timerValue = 0;
        }

        if (spawnPos.x == 6)
        {
            timerValue = 0;
        }
    }


}
