using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField]
    float frequency;
    [SerializeField]
    float magnitude;
    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        frequency = Random.Range(5f, 10f);
        magnitude = 0.2f;
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + new Vector3(.0f, Mathf.Sin(Time.time*frequency)*magnitude, .0f);


    }
}
