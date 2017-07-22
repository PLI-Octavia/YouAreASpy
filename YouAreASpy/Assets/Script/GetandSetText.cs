using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetandSetText : MonoBehaviour {

    public InputField resulttexte;
    public Text resultT;


    
    public void setget()
    {
        
        int resultCast = Int32.Parse(resulttexte.text);
        resultT.text = "Your resul is : " + resulttexte.text + " ! ";
       
        Debug.Log("instance : "+ GameManagement.Instance.result);

        if (resultCast == GameManagement.Instance.result)
        {
            resultT.text = "ok";
        }
        else
        {
            resultT.text = "KO pute pute pute";
        }
    }
}
