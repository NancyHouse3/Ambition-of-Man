using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public Object playerCountry;
    public GameObject eventPrefab;
    public TextMeshProUGUI populationText;
    public Color playerColor;
    public long population;
    public Transform Kanvas;

    // Start is called before the first frame update
    void Start()
    { 
        ReceiveEvent
            (
            "Winston Smith is ALIVE",
            "The thought criminal who was put in prison isn't actually dead afterall. What a surpise!",
            "Wow"
            );
    }

    // Update is called once per frame
    void Update()
    {
        if (populationText)
        {
            populationText.text = population.ToString();
        }
    }

    void ReceiveEvent(string title,string body,string response)
    {
        GameObject newEvent = Instantiate(eventPrefab, Kanvas);
        TMP_Text[] tmpTextComponents = newEvent.GetComponentsInChildren<TMP_Text>();
        foreach (TMP_Text tmpText in tmpTextComponents)
        {
            switch (tmpText.name)
            {
                case "Headline":
                    tmpText.text = title;
                    break;
                case "Bodytext":
                    tmpText.text = body;
                    break;
                case "Response":
                    tmpText.text = response;
                    break;
                default:
                    tmpText.text = "#";
                    break;
            }
        }
    }
}
