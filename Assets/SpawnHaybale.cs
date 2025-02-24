using System;
using System.IO.Pipes;
using UnityEngine;

public class SpawnHaybales : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject haybale;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 4;
    void Start() {
        spawnHaybale();
    }

    // Update is called once per frame
    void Update() {
        if (timer < spawnRate) {
            timer = (float)(timer + Time.deltaTime * 1.4);
        } else {
            spawnHaybale();
            timer = 0;
        }
    }

    void spawnHaybale() {
        Debug.Log("Haybale spawned.");
        float lowest = Math.Max(transform.position.y - heightOffset, -2.6f);
        float highest = Math.Min(transform.position.y + heightOffset, 1.8f);
        Instantiate(haybale, new Vector3(transform.position.x,
         UnityEngine.Random.Range(lowest, highest), 0), transform.rotation);
    }
}
