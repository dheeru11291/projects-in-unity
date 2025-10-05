using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float spawnTime = 0;
    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime = spawnTime + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            spawnTime = 0;

        }
    }
    void spawnpipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint= transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}