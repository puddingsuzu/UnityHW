using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public GameObject EndMenu;
    public GameObject SeedMaxOnoff;
    public GameObject SeedCountOnoff;
    public Text SeedMax;
    public Text SeedCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SeedCount.text = Grass.Seed.ToString();
        if (Grass.Seed == 20)
        {
            EndMenu.SetActive(true);
            SeedMaxOnoff.SetActive(false);
            SeedCountOnoff.SetActive(false);
        }
    }

}
