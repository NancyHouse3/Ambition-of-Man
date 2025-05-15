using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CityScript : MonoBehaviour
{

    public string cityName;
    public int population;
    public TextMeshPro cityLabel;
    public Object cityBlock;

    // Start is called before the first frame update
    void Start()
    {
        if (cityName.Equals(""))
        {
            cityName = "jeff";
        }

        if (!cityBlock.name.Equals(cityName))
        {
            cityBlock.name = cityName;
        }

        cityLabel.text = cityName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
