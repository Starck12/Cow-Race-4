using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCow : MonoBehaviour
{
    private float speed;
    // Update is called once per frame
    void Update()
    {
        float min = 0.2f;
        float max = 5f;
        speed = Random.Range(min, max) + 1;
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
