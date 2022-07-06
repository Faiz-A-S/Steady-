using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public GameObject papan;
    public Vector3 paketA;
    public int intervalGanti;
    
    private float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(papan.transform.eulerAngles);
        //make random rotate for ground
        if((int)timer >= intervalGanti)
        {
            
            paketA = new Vector3(Random.Range(-4, 5), 0, Random.Range(-4, 5));
            timer = 0;
        }

        //prevents ground to rotate 180
        if(papan.transform.eulerAngles.x >= 350 )
        {
            //paketA = new Vector3(5, 0, Random.Range(-4, 5));
            Debug.Log("1");
            paketA = new Vector3(5, 0, 0);
        }
        else if (papan.transform.eulerAngles.x >= 12 && papan.transform.eulerAngles.x <= 330)
        {
            Debug.Log("2");
            //paketA = new Vector3(-5, 0, Random.Range(-4, 5));
            paketA = new Vector3(-5, 0, 0);
        }
        else if(papan.transform.eulerAngles.z >= 330 && papan.transform.eulerAngles.x <= 340)
        {
            Debug.Log("3");
            //paketA = new Vector3(Random.Range(-4, 5), 0, 5);
            paketA = new Vector3(0, 0, 5);
        }
        else if(papan.transform.eulerAngles.z >= 12 && papan.transform.eulerAngles.x <= 330)
        {
            Debug.Log("4");
            //paketA = new Vector3(Random.Range(-4, 5), 0, -5);
            paketA = new Vector3(0, 0, -5);
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        //yes move
        papan.transform.Rotate(paketA * Random.Range(0,5) * Time.deltaTime);
    }
}
