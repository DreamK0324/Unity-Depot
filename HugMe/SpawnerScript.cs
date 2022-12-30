using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject basketballPrefab;
    public float height;
    public float maxSpawn = 1;
    public float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newEnter = Instantiate(basketballPrefab);
        newEnter.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxSpawn)
        {
            GameObject newEnter = Instantiate(basketballPrefab);
            newEnter.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
