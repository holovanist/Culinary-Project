using UnityEngine;
using TMPro;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;

    //use a list to calculate
    //playerprefs to save settings
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float flourCost = -1;
            Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
            Debug.Log(flourAmt * flourCost);
        }
    }
}
