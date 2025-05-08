using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeChairs : MonoBehaviour
{
    public GameObject[] chairs; 
    private int counter = 0;

    public void nextChair()
    {
        counter++;

        if (counter == chairs.Length)
        {
            counter = 0;
        }

        for( int i = 0; i < chairs.Length; i++)
        {
            chairs[i].gameObject.SetActive(false);
        }
        chairs[counter].gameObject.SetActive(true);

    }


    public void backChair()
    {
        counter--;


        if (counter < 0)
        {
            counter = chairs.Length - 1;
        }

        for (int i = 0; i < chairs.Length; i++)
        {
            chairs[i].gameObject.SetActive(false);
        }
        chairs[counter].gameObject.SetActive(true);

    }

}
