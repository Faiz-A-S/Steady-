using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRandom : MonoBehaviour
{
    public Transform area;
    public GameObject pointArea;
    public float areaMin, areaMax;
    public float spawnMove;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnMove)
        {
            pointArea.transform.localPosition = new Vector3(Random.Range(areaMin, areaMax), area.position.y + 0.55f, Random.Range(areaMin, areaMax));
            timer = 0;
        }
    }
}
