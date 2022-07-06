using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointArea : MonoBehaviour
{
    public int poin;

    private float timer;
    private Renderer color;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        color = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        color.material.color = Color.green;
        //Debug.Log("POINT")63FF00;
        if (timer >= 2)
        {
            poin += 1;
            timer = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        color.material.color = Color.white;
    }
}
