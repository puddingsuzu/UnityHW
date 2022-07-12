using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grass : MonoBehaviour
{
    public static int Seed = 0;
    public GameObject grass;
    public float m_LifeTime;
    private float m_NewLifeTime;

    private void Awake()
    {
        m_NewLifeTime = m_LifeTime;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_LifeTime -= 1.0f * Time.deltaTime;
        if (m_LifeTime < 0)
        {
            ObjectPool.instance.Recovery(gameObject);
            m_LifeTime = m_NewLifeTime;
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
