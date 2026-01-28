using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawn : MonoBehaviour
{
    public GameObject tankPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Instantiate(tankPrefab);
        }
    }
}
