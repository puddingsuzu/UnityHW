using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.0f, 0.25f, 0.0f);
    }
}
