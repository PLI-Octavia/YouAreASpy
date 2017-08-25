using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetandSetText : MonoBehaviour {
	public SpawnScript spawnscript;
    public InputField resulttexte;
    public Text resultT;
	public Text Score;
    public ParticleSystem explosion;
    public void setget()
    {
		int resultCast = Int32.Parse(resulttexte.text);
        resultT.text = "Your result is : " + resulttexte.text + " ! ";
		
		Debug.Log("debut "+ Singleton.Instance.score);
		if (resultCast == Singleton.Instance.result)
        {
			Singleton.Instance.score += 10;
			resultT.text = "Bien jouer !";
			Score.text = "Score : "+Singleton.Instance.score.ToString();
			Destroy(GameObject.FindWithTag("calc"));

			Singleton.Instance.calculInProgress = false;
		}
        else
        {
			Singleton.Instance.life -= 1;
			Debug.Log(Singleton.Instance.life);
			if (Singleton.Instance.life <= 0)
			{
				Destroy(GameObject.FindWithTag("bomb"));
				Destroy(GameObject.FindWithTag("flamme"));
				Destroy(GameObject.FindWithTag("calc"));
				resultT.text = "Game Over"+" your score : " + Singleton.Instance.score.ToString();
				GameObject.Instantiate(this.explosion, new Vector3(0, -1, 0), Quaternion.Euler(-90, 0, 0));
				explosion.Play();
			}
			else
			{
				Destroy(GameObject.FindWithTag("calc"));
				resultT.text = "Faux !"+ Singleton.Instance.life +" vie";
				Singleton.Instance.calculInProgress = false;
			} // end if / else (life == 0)

		} // end if / else (resultCast == Singleton.Instance.result)
	}
}
