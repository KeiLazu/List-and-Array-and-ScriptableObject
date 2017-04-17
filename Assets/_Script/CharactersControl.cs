using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersControl : MonoBehaviour {

    [SerializeField]
    public List<ListCharacters> characters;
    protected ListCharacters CharactersClass;

    protected int counting;
    protected int randomPower;

    [SerializeField]
    Text[] lblNameChara;
    [SerializeField]
    Text[] lblPowerChara;

	// Use this for initialization
	void Start () {

        characters = new List<ListCharacters>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Randomizing();
            characters.Add(new ListCharacters("Natsume", randomPower));
            Debug.Log("Added: Natsume - " + randomPower);
            status();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            characters.RemoveAt(counting-1);
            status();
        }
		
	}

    void Randomizing()
    {
        randomPower = UnityEngine.Random.Range(0, 100);
    }

    void status()
    {

        counting = characters.Count;
        Debug.Log("Remaining: " + counting);

        /**
         * i'll fix this to be an automaton, i mean auto insert into those text, 
         * next up: sprites, page and scriptableobjects
         */

        try
        {
            if (counting > 0)
            {
                lblNameChara[0].text = "Name: " + characters[0].get_nameChara;
                lblPowerChara[0].text = "Power: " + characters[0].get_powerChara;
            } else { Debug.Log("Empty"); lblNameChara[0].text = ""; lblPowerChara[0].text = ""; }
        } catch (Exception e)
        {
            Debug.Log("No Array Here, Boss \n" + e);
        }
    }
}
