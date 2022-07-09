using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grass : MonoBehaviour
{
    public static int Seed = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag.Equals("Player"))
        {
            Destroy(gameObject);
            //Seed += 1;
            Seed = 20;
        }
    }

}
