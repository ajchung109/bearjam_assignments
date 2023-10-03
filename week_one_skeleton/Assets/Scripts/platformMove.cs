using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    [SerializeField] private float speed = 2f;

    private int currIndex = 0; 

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(points[currIndex].transform.position, transform.position) < 0.1f)
        {
            currIndex += 1;
            if (currIndex >= points.Length)
            {
                currIndex = 0; 
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[currIndex].transform.position, Time.deltaTime * speed); 
    }
}
