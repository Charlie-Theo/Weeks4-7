using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawn : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public GameObject spawnedTank;

    public FirstScript tankScript;

    public List<GameObject> tanks;
    public Transform barrel;

    public GameObject duckiePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Instantiate a prefab: make this one appear
            //Instantiate a prefab, a Vector2 or Vector3, a Quaternion: make it appear at this position and rotation
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            Vector2 spawnPos = Random.insideUnitCircle * 3;
            //Quaternion identity means no rotation which is the same as Euler angles (0, 0, 0)
            spawnedTank = Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            tankScript = spawnedTank.GetComponent<FirstScript>();
            //tankSR = spawnedTank.GetComponent<SpriteRenderer>();

            howManyTanks++;

            //tankScript.speed = howManyTanks;
            //tankScript.body.color = Random.ColorHSV();

            tanks.Add(spawnedTank);

            Instantiate(duckiePrefab, Random.insideUnitCircle * 3, Quaternion.identity);
        }

        if(Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            tanks.Remove(spawnedTank);
            Destroy(spawnedTank);
        }

        //loop through the list of tanks: these are GameObjects
        //get that tanks's transform
        //compare that to the barrel: is the tank at the same positionas the barrel?
        for (int i = tanks.Count - 1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
                if(distance < 0.5f)
            {
                Debug.Log("Explode tank" + i);
                //make a local variable to get a reference to the tank
                GameObject tank = tanks[i];
                //remove the tank from the list
                tanks.Remove(tank);
                tanks.RemoveAt(i);
                //destory the tank
                Destroy(tank);

            }
        }

        //if (Mouse.current.rightButton.wasPressedThisFrame == true)
        //{
        //    //Instantiate a prefab, a Transform: makes it appear at 0, 0, as the child of that transform
        //    Instantiate(tankPrefab, transform);
        //}
    }
}
