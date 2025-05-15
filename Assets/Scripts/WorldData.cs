using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WorldData : MonoBehaviour
{
    public int year = 1900;
    public float timeBetweenYears = 3f;
    private float timer = 0f;
    public TextMeshProUGUI yearLabel;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenYears)
        {
            year++;
            timer = 0;
            yearLabel.text = year.ToString();
        }
    }

}
