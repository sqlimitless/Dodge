using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPerfab;
    private readonly float spawnRateMin = 0.5f;
    private readonly float spawnRateMax = 3;
    
    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    void Start()
    {
        timeAfterSpawn = 0;
        spawnRate = Random.Range(spawnRateMin,spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if(timeAfterSpawn >= spawnRate){
            timeAfterSpawn = 0;
            GameObject bullet = Instantiate(bulletPerfab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnRate = Random.Range(spawnRateMin,spawnRateMax);
        }
    }
}
