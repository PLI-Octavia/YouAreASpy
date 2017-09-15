using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SpawnScript : MonoBehaviour {

    public Calcul calcul;
    public GetandSetText getandset;
    public GameObject[] all_number;
    public GameObject[] all_operation;
    public GameObject[] Input_result;
    //  public GameObject[] input_text;
    private GameObject EmptyGameObject;
    private int nbCalcule;

    void Start()
    {
		Singleton.Instance.calculInProgress = false;
    }

    // Update is called once per frame
    void Update()
    {
		
        if (!Singleton.Instance.calculInProgress)
        {
			Singleton.Instance.calculInProgress = true;
			//On génère l'objet vide qui va contenir le calcul et on attribue tout ce dont on aura besoin
			this.EmptyGameObject = new GameObject();
			this.EmptyGameObject.tag = "calc";
			EmptyGameObject.transform.position = new Vector3(-5, 4, 0);

            //On génère le calcul
            this.calcul = new Calcul();
            calcul.generateCalcul();

            //Link du premier chiffre au parent
            GameObject Param1Child = Instantiate(all_number[calcul.x]) as GameObject;
            Param1Child.transform.parent = EmptyGameObject.transform;
            Param1Child.transform.position = transform.position;

            //Link du premier opérateur au parent
            GameObject OpChild = Instantiate(all_operation[0]) as GameObject;
            OpChild.transform.parent = EmptyGameObject.transform;
            OpChild.transform.position = new Vector3((transform.position.x + 1.6f), transform.position.y, 0.0f);

            //Link du deuxième chiffre au parent
            GameObject Param2Child = Instantiate(all_number[calcul.y]) as GameObject;
            Param2Child.transform.parent = EmptyGameObject.transform;
            Param2Child.transform.position = new Vector3((transform.position.x + 3.2f), transform.position.y, 0.0f);

            //Link du deuxième opérateur au parent
            GameObject EgalChild = Instantiate(all_operation[1]) as GameObject;
            EgalChild.transform.parent = EmptyGameObject.transform;
            EgalChild.transform.position = new Vector3((transform.position.x + 4.8f), transform.position.y, 0.0f);

            
            Singleton.Instance.result = calcul.x * calcul.y;

            //  GameObject resultAllChild = Instantiate(input_text[0]) as GameObject;
            //  resultAllChild.transform.parent = EmptyGameObject.transform;
            //  resultAllChild.transform.position = new Vector3((transform.position.x + 6.8f), transform.position.y, 0.0f);
            //correct = GameManagement.rnd.Next(0, 50);

            //resultat = calcul.doCalcul(calcul.x, calcul.y, calcul.operation, tmp.isCorrect);
            //ParthNumber(resultat);
        }
    }

    void ParthNumber(int resultat)
    {
        //On convertit le resultat du calcul en String afin de parther les chiffres
        string res = resultat.ToString();
        int i = 0;
        float x = 2.1f;

        while (i != res.Length)
        {
            //On génère les chiffres un par un et on les places
            GameObject AnwserChild = Instantiate(all_number[(int)Char.GetNumericValue(res[i])]) as GameObject;
            AnwserChild.transform.parent = EmptyGameObject.transform;
            AnwserChild.transform.position = new Vector3((transform.position.x + x), transform.position.y, 0.0f);
            x += 0.3f;
            i++;
        }
    }
}