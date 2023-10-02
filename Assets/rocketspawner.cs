using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketspawner : MonoBehaviour
{
    public GameObject rocket;
    public GameObject[] weaponPos;
    float timer;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            Instantiate(rocket, weaponPos[0].transform.position, transform.localRotation);
            Instantiate(rocket, weaponPos[1].transform.position, transform.localRotation);
            timer = 0;
        }
    }
}
