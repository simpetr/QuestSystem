using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    float speed = 30f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(.0f, speed * Time.deltaTime, .0f));
    }
}
