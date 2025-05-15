using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "N_Country", menuName = "AoM/Country")]
public class CountryData : ScriptableObject
{
    public string countryName;
    public Ideology ideology;
    public Texture flag;
    public Color countryColor;
    public int politicalPower;
    public int militaryBonus; // making things simple by combinding multiple factors into one
    public int money;
    public int stability;
    public int warSupport;
    public int population;

    public enum Ideology
    {
        Socialism,
        Communism,
        Republic,
        Democracy,
        Fascism,
        Autocracy,
        Oligarchy,
        Anarchism
    }
}

/*
 */