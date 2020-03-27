using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    // Start is called before the first frame update
    public block objectToSpawn;
    public float spawnRate;

    private Transform nextPosition;
    void Start()
    {
        nextPosition = transform;
        StartCoroutine(startSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator startSpawning()
    {
        while (true)
        {
            block spawnedPiece = Instantiate(objectToSpawn, nextPosition);
            nextPosition = spawnedPiece.getNextPos();
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
