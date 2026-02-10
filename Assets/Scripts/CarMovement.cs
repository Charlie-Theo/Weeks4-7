using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed;
    public Vector2 startPos;
    Vector2 newPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.z = 270;
        transform.eulerAngles = rotate;


        //setting random start position & speed
        startPos.x = -11;
        startPos.y = Random.Range(-3.5f, 3.5f);
        transform.position = startPos;

        speed = Random.Range(2, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (newPos.x > 11)
        {
            newPos = startPos;
        }
        else
        {
            newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
        }

        transform.position = newPos;
    }
}
