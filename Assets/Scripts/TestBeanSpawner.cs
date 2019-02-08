using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBeanSpawner : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float Rate;

    float counter = 0;
    
    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter <= 0f)
        {
            Spawn();
            counter = Rate;
        }
    }

    void Spawn()
    {
        int index = Random.Range(0, Prefabs.Length);
        Instantiate(Prefabs[index], transform.position, Random.rotation);
    }
}
