using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour
{
    float speedOfCircle = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        speedOfCircle = 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * speedOfCircle * Time.deltaTime);
    }
}
