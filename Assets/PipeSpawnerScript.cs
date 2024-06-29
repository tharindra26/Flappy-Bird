using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2;
    private float timer = 0;
 
    public float heighOffSet = 20;
    void Start()
    {
        pipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
            return;
        }else{
            pipeSpawn();
            timer = 0;
        }
        
    }

    void pipeSpawn(){
        float lowestPoint= transform.position.y - heighOffSet;
        float highestPoint= transform.position.y + heighOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}
