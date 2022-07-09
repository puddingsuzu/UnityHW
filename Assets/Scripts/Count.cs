using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public GameObject EndMenu;
    public Text seedCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seedCount.text = Grass.Seed.ToString();
        if (Grass.Seed == 20)
        {
            EndMenu.SetActive(true);
        }
    }

}
