using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{

    // Test de creation d'une carte
    public GameObject cardPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space is active");
            GameObject carte = Instantiate(cardPrefab) as GameObject;
            GameObject canvas = GameObject.Find("Canvas");
            carte.transform.SetParent(canvas.transform);
            carte.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
}
