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
        //checks if there is a leaf currently not active
        if (spawnedLeaf == null)
        {
            //Y: increase timer
            timerValue += Time.deltaTime;
        }
        //N: do nothing

        //checks if the timer has hit the max
        if (timerValue > timerMax)
        {
            //Y: spawns a leaf prefab in a random position near the plant
            Vector2 spawnPos;

            spawnPos.x = Random.Range(-1, 1);
            spawnPos.y = Random.Range(-1, 1);

            spawnedLeaf = Instantiate(leafPrefab, spawnPos, Quaternion.identity);

            //resets timer
            timerValue = 0;
        }
        //N: do nothing

        //checks if there is a current leaf object
        if (spawnedLeaf != null)
        {
            //Y: updates the position and rotation of the leaf object
            Vector2 leafPos;
            Vector3 leafRot;
            leafPos = spawnedLeaf.transform.position;
            leafRot = spawnedLeaf.transform.eulerAngles;

            //-speed from the position to make the leaf fall
            leafPos.y -= speed * Time.deltaTime;
            spawnedLeaf.transform.position = leafPos;

            //+rotation from the eulerAngles to make the leaf rotate
            leafRot.z += rotation;
            spawnedLeaf.transform.eulerAngles = leafRot;

            //checks if the leaf position is below -7
            if (leafPos.y < -7)
            {
                //Y: destorys the leaf object
                Destroy(spawnedLeaf);
            }
            //N: do nothing
        }
        //N: do nothing
    }
}
