using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;


    int i = 3;
    int random;

    // Start is called before the first frame update
    void Start()
    {
       random = Random.Range(150, 251);

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == random)
        {
            rend.enabled = false;
        }

    }
}
