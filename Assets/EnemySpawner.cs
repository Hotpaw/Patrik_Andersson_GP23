using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    public Transform player;
    float timer;
    public float cooldown;
    public int EnemyId;
    int counter = 0;
    int circleRadius;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            timer = 0;
            if(counter == 3)
            {
                EnemyId = 1;
                circleRadius = 30;
                counter = 0;
            }
            else
            {
                EnemyId = 0;
                circleRadius = 10;
            }
            SpawnEnemy(EnemyId);
            counter++;
            
        }
    }

    // Update is called once per frame
    public void SpawnEnemy(int enemyId)
    {
        circleRadius = 10;
        Vector3 randomPosition = Random.insideUnitCircle * circleRadius;
       
        while(randomPosition.sqrMagnitude < 3*3) 
        {
            randomPosition = Random.insideUnitCircle * circleRadius;
        }

        GameObject EnemyClone = Instantiate(enemyPrefabs[enemyId].gameObject, player.transform.position + randomPosition, transform.rotation);
        
       
    }
    
}
