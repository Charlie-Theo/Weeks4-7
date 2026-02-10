using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject spawnedCar;
    public GameObject player;

    public List<GameObject> cars;
    public CarMovement carScript;

    public AudioSource audioSource;
    public AudioClip catDieSFX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carScript = carPrefab.GetComponent<CarMovement>();

        for (int i = 0; i < 5; i++)
        {
            spawnedCar = Instantiate(carPrefab, carScript.startPos, Quaternion.identity);
            cars.Add(spawnedCar);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //checking for collision
        for (int i = 0; i < cars.Count; i++)
        {
            //getting car position & player position
            Vector2 carPos = cars[i].transform.position;
            Vector2 playerPos = player.transform.position;

            float distance = Vector2.Distance (carPos, playerPos);
            if (distance < 0.5f)
            {
                audioSource.PlayOneShot(catDieSFX);
                playerPos.x = 0;
                playerPos.y = -4;
                player.transform.position = playerPos;

                for (int j = 0; j < cars.Count; j++)
                {
                    carScript = cars[j].GetComponent<CarMovement>();
                    cars[j].transform.position = carScript.startPos;
                }
            }
        }
    }
}
