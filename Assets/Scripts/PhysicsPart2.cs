using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPart2 : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 aim = new();
    public float speedReductionMultiplier;
    float timer;
    float cooldown = 3;
    float deathcount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        aim = transform.position - player.transform.position;
        transform.up = aim;
       
        rb.AddForce(-aim);
        timer += Time.deltaTime;
        if (timer > cooldown && deathcount != 10)
        {
            rb.velocity = Vector2.zero;
            deathcount++;
            timer = 0;
        }else if(deathcount == 10)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
           
        }
    }
    public void DestroyRocket()
    {
        Destroy(gameObject, 0.2f);
    }
}
