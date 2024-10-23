using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class List : MonoBehaviour
{
    public TextMeshProUGUI MyText;

    float number;
    float number2;
    float number3;

    [SerializeField]
    TMP_InputField MarkUp;
    [SerializeField]
    TMP_InputField TotalAmount;

    [SerializeField]
    TMP_InputField i_1Amt;
    [SerializeField]
    TMP_InputField i_2Amt;
    [SerializeField]
    TMP_InputField i_3Amt;
    [SerializeField]    
    TMP_InputField i_4Amt;
    [SerializeField]   
    TMP_InputField i_5Amt;
    [SerializeField]
    TMP_InputField i_6Amt;
    [SerializeField]
    TMP_InputField i_7Amt;
    [SerializeField]
    TMP_InputField i_8Amt; 
    [SerializeField]
    TMP_InputField i_9Amt;
    [SerializeField]
    TMP_InputField i_10Amt;   
    [SerializeField]
    TMP_InputField i_11Amt;  
    [SerializeField] 
    TMP_InputField i_12Amt;   
    [SerializeField]
    TMP_InputField i_13Amt; 
    [SerializeField]   
    TMP_InputField i_14Amt;
    [SerializeField]
    TMP_InputField i_15Amt;

    [SerializeField]
    TMP_InputField i_1Cost;
    [SerializeField]
    TMP_InputField i_2Cost;
    [SerializeField]
    TMP_InputField i_3Cost;
    [SerializeField]
    TMP_InputField i_4Cost;
    [SerializeField]
    TMP_InputField i_5Cost;
    [SerializeField]
    TMP_InputField i_6Cost;
    [SerializeField]
    TMP_InputField i_7Cost;
    [SerializeField]
    TMP_InputField i_8Cost;
    [SerializeField]
    TMP_InputField i_9Cost;
    [SerializeField]
    TMP_InputField i_10Cost;
    [SerializeField]
    TMP_InputField i_11Cost;
    [SerializeField]
    TMP_InputField i_12Cost;
    [SerializeField]
    TMP_InputField i_13Cost;
    [SerializeField]
    TMP_InputField i_14Cost;
    [SerializeField]
    TMP_InputField i_15Cost;

    private void Start()
    {
        MyText.text = "";
        number = 0;
        number2 = 0;
    }
    public void Calculate()
    {
        float Markup = -1;
        float.TryParse(MarkUp.text, out Markup);
        float Total = -1;
        float.TryParse(TotalAmount.text, out Total);
        float OneCost = -1;
        float.TryParse(i_1Cost.text, out OneCost);
        float OneAmt = -1;
        float.TryParse(i_1Amt.text, out OneAmt);
        float TwoCost = -1;
        float.TryParse(i_2Cost.text, out TwoCost);
        float TwoAmt = -1;
        float.TryParse(i_2Amt.text, out TwoAmt);
        float ThreeCost = -1;
        float.TryParse(i_3Cost.text, out ThreeCost);
        float ThreeAmt = -1;
        float.TryParse(i_3Amt.text, out ThreeAmt);
        float FourCost = -1;
        float.TryParse(i_4Cost.text, out FourCost);
        float FourAmt = -1;
        float.TryParse(i_4Amt.text, out FourAmt);
        float FiveCost = -1;
        float.TryParse(i_5Cost.text, out FiveCost);
        float FiveAmt = -1;
        float.TryParse(i_5Amt.text, out FiveAmt);
        float SixCost = -1;
        float.TryParse(i_6Cost.text, out SixCost);
        float SixAmt = -1;
        float.TryParse(i_6Amt.text, out SixAmt);
        float SevenCost = -1;
        float.TryParse(i_7Cost.text, out SevenCost);
        float SevenAmt = -1;
        float.TryParse(i_7Amt.text, out SevenAmt);
        float EightCost = -1;
        float.TryParse(i_8Cost.text, out EightCost);
        float EightAmt = -1;
        float.TryParse(i_8Amt.text, out EightAmt);
        float NineCost = -1;
        float.TryParse(i_9Cost.text, out NineCost);
        float NineAmt = -1;
        float.TryParse(i_9Amt.text, out NineAmt);
        float TenCost = -1;
        float.TryParse(i_10Cost.text, out TenCost);
        float TenAmt = -1;
        float.TryParse(i_10Amt.text, out TenAmt);
        float ElevenCost = -1;
        float.TryParse(i_11Cost.text, out ElevenCost);
        float ElevenAmt = -1;
        float.TryParse(i_11Amt.text, out ElevenAmt);
        float TwelveCost = -1;
        float.TryParse(i_12Cost.text, out TwelveCost);
        float TwelveAmt = -1;
        float.TryParse(i_12Amt.text, out TwelveAmt);
        float ThirteenCost = -1;
        float.TryParse(i_13Cost.text, out ThirteenCost);
        float ThirteenAmt = -1;
        float.TryParse(i_13Amt.text, out ThirteenAmt);
        float FourteenCost = -1;
        float.TryParse(i_14Cost.text, out FourteenCost);
        float FourteenAmt = -1;
        float.TryParse(i_14Amt.text, out FourteenAmt);
        float FithteenCost = -1;
        float.TryParse(i_15Cost.text, out FithteenCost);
        float FithteenAmt = -1;
        float.TryParse(i_15Amt.text, out FithteenAmt);
        Debug.Log(FithteenAmt * FithteenCost);
        number = OneAmt*OneCost+TwoAmt*TwoCost+ThreeAmt*ThreeCost+FourAmt*FourCost+FiveAmt*FiveCost+SixAmt*SixCost+SevenAmt*SevenCost+EightAmt*EightCost+NineAmt*NineCost+TenAmt*TenCost+ElevenAmt*ElevenCost+TwelveAmt*TwelveCost+ThirteenAmt*ThirteenCost+FourteenAmt*FourteenCost+FithteenAmt*FithteenCost;
        number2 =number*Markup;
        number3 = number2 / Total;
        MyText.text = number3.ToString();
    }
}
