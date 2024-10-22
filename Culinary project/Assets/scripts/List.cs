using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class List : MonoBehaviour
{
    //use list to tell haw many ingrediants ther are
    //use list to tell how much they cost
    //divide the cost by the ingrediant ex ingrediant / cost = raw cost
    //multiply the new cost by the amount they need
    //multiply the raw cost by the mark up = markup value
    //then divide the markup value by the amount made
    public void Calculate()
    {
        GameObject[] Cost = GameObject.FindGameObjectsWithTag("Cost");
        //TMP_InputField[] Amount = GameObject.FindObjectsOfType<TMP_InputField>();
        //TMP_InputField[] Need = GameObject.FindObjectsOfType<TMP_InputField>();
        Debug.Log(Cost.Length);
        Debug.Log(Cost);
        
    }
}
