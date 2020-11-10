using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField]
    float frequency;
    [SerializeField]
    float magnitude;
    Vector3 startingScale;
    // Start is called before the first frame update
    void Start()
    {
        frequency = Random.Range(1f, 5f);
        magnitude = 0.2f;
        startingScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        float scalingFactor = Mathf.Sin(Time.time * frequency) * magnitude;
        transform.localScale = startingScale + new Vector3(scalingFactor, scalingFactor, scalingFactor);


    }
}
