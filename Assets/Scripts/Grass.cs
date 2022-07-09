using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grass : MonoBehaviour
{
    public static int Seed = 0;

    public GameObject grass;
    public ObjectPool pool;
    public float m_lifetime = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_lifetime -= 1.0f * Time.deltaTime;
        if (m_lifetime < 0)
        {
            pool.Recovery(grass);
            Debug.Log("Recovery");
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag.Equals("Player"))
        {
            Destroy(gameObject);
            Seed += 1;
        }
    }
}
