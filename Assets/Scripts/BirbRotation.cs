using UnityEngine;

public class BirbRotation : MonoBehaviour
{
    public float speed = 0;

    Vector3 newRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newRot = transform.eulerAngles;
        newRot.z += speed * Time.deltaTime;
        transform.eulerAngles = newRot;
    }

    public void StartSpin()
    {
        speed = 100;
    }

    public void EndSpin()
    {
        speed = 0;
    }
}
