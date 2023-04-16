using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;
    public float maxDistance, minDistance;
    public float spawnDistance;

    private Rigidbody rb;

    public float pipeSpeed;

    private float lastSpawn;

    private List<GameObject> pipes = new List<GameObject>();

    public float destroyPosition;

    public GameObject bird;

    private Manager manager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine (PipeSpawner());
        lastSpawn = transform.position.x;

        manager = FindObjectOfType<Manager>();
    }

    private void Update()
    {
        foreach(GameObject pipe in pipes)
        {
            pipe.transform.position += Vector3.left * pipeSpeed * Time.deltaTime;

            if (pipe.transform.position.x < destroyPosition)
            {
                pipes.Remove(pipe);
                Destroy(pipe);
                break;
            }
          

        }


    }

    IEnumerator PipeSpawner()
    {
        while (true)
        {
            GameObject newPipe = Instantiate(pipePrefab);

            float randomHeight = Random.Range(minDistance, maxDistance);

            Vector3 pipePosition = new Vector3(lastSpawn + spawnDistance, randomHeight, 0);

            newPipe.transform.position = pipePosition;

            

            pipes.Add(newPipe);

            

            yield return new WaitForSeconds(1.5f);
        }
    }

    



}
