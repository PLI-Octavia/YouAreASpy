using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetandSetText : MonoBehaviour {

    public InputField resulttexte;
    public Text resultT;
    public ParticleSystem explosion;

    public void setget()
    {
        
        int resultCast = Int32.Parse(resulttexte.text);
        resultT.text = "Your resul is : " + resulttexte.text + " ! ";

        if (resultCast == Singleton.Instance.result)
        {
            resultT.text = "GOOD GAME";
            Destroy(GameObject.FindWithTag("flamme"));
        }
        else
        {
            Destroy(GameObject.FindWithTag("bomb"));
            Destroy(GameObject.FindWithTag("flamme"));
           
            resultT.text = "GAME OVER";

            GameObject.Instantiate(this.explosion, new Vector3(0,-1,0), Quaternion.Euler(-90, 0, 0));
            explosion.Play();
        }
    }
}
