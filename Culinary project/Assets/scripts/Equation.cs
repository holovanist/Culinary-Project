using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Equation : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;
    [SerializeField]
    TMP_InputField i_1a;
    [SerializeField]
    TMP_InputField i_2a;
    [SerializeField]
    TMP_InputField i_1b;
    [SerializeField]
    TMP_InputField i_2b;
    [SerializeField]
    TMP_InputField i_1c;
    [SerializeField]
    TMP_InputField i_2c;
    public void Calculate()
    {

        float flourCost = -1;
        Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
        float flourAmt = -1;
        Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
        Debug.Log(flourAmt * flourCost);
    }
    /*using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class List : MonoBehaviour
{

    List<TMP_InputField> Ingrediant;
    //use list to tell haw many ingrediants ther are
    //calculate using the list
    //save the list in playerprefs
    //
    void Update()
    {

    }
    public void Calculate()
    {
        //TMP_InputField[] foo = GameObject.FindObjectsOfType<TMP_InputField>();
        
                
        
        Debug.Log(ToString(Ingrediant));
    }
}
*/
}
