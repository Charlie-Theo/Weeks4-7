using UnityEngine;

public class SpawningLeaves : MonoBehaviour
{
    public GameObject leafPrefab;
    public GameObject spawnedLeaf;

    public float timerValue = 0;
    public float timerMax = 5;

    public float rotation = 1;
    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnedLeaf == null)
        {
            timerValue += Time.deltaTime;
        }

        if (timerValue > timerMax)
        {
            Vector2 spawnPos;

            spawnPos.x = Random.Range(-1, 1);
            spawnPos.y = Random.Range(-1, 1);

            spawnedLeaf = Instantiate(leafPrefab, spawnPos, Quaternion.identity);

            timerValue = 0;
        }

        if (spawnedLeaf != null)
        {
            Vector2 leafPos;
            Vector3 leafRot;
            leafPos = spawnedLeaf.transform.position;
            leafRot = spawnedLeaf.transform.eulerAngles;

            leafPos.y -= speed * Time.deltaTime;
            spawnedLeaf.transform.position = leafPos;

            leafRot.z += rotation;
            spawnedLeaf.transform.eulerAngles = leafRot;

            if (leafPos.y < -7)
            {
                Destroy(spawnedLeaf);
            }
        }
    }
}
