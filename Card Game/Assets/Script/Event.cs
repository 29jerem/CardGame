using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{

    // Test de creation d'une carte
    public GameObject cardPrefab;
    public int increment;

    // Update is called once per frame
    void Update()
    {

        // Event when user use Space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Create a prefab Card
            GameObject carte = Instantiate(cardPrefab) as GameObject;

            // Position the card
            GameObject canvas = GameObject.Find("Canvas");
            carte.transform.SetParent(canvas.transform);
            carte.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            // Give an id which increase each time user create a card
            carte.GetComponent<CardDisplay>().idCardDataBase = increment;
            increment++;
            Debug.Log("L'identifiant de la carte est : " + carte.GetComponent<CardDisplay>().idCardDataBase);

            // Give the information of the card
            
            
            //  Check if the card back is false
            if(!carte.GetComponent<CardDisplay>().isBack)
            {
                // To disable the card back
                GameObject cardBack = carte.transform.Find("Back").gameObject;
                if(cardBack)
                {
                    cardBack.SetActive(false);
                }
            }
            
            
        }
    }
}
