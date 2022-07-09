using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
        public ObjectPool pool;
        public float SpawnTime = 1.0f;
        private float Timer;

        void Update()
        {
            if (Time.time > Timer + SpawnTime)
            {
                Timer = Time.time;
                pool.ReUse(new Vector3(Random.Range(25, 47), 4.0f, Random.Range(26, 50)), transform.rotation);
            }
    }
}
