using UnityEngine;

public class SpawningPlant : MonoBehaviour
{
    public GameObject plantPrefab;
    public GameObject spawnedPlant;

    public GrowingPlant plantScript;

    public float plantGrowth = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnedPlant = Instantiate(plantPrefab);
        plantScript = spawnedPlant.GetComponent<GrowingPlant>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void resetPlant()
    {
        plantGrowth = 0;
        Destroy(spawnedPlant);
        spawnedPlant = Instantiate(plantPrefab);
    }

    public void grow()
    {
        if (plantGrowth < 0.3)
        {
            plantGrowth += 0.03f;
        }

        Vector2 plantSize;
        plantSize.x = plantGrowth;
        plantSize.y = plantGrowth;

        spawnedPlant.transform.localScale = plantSize;
    }
}
