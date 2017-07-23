using UnityEngine;
using System.Collections;
using System;

public class Calcul {

    public int x;
    public int y;
    public int operation;

    //Fonction qui génère les paramètres du calcule de façon aléatoire
    public void generateCalcul()
    {
        //System.Random rnd = new System.Random();

        //TODO : GET what the teacher congif : 
        //If don't have config it is a random session
        Debug.Log(Singleton.Instance);          
        this.x = Singleton.Instance.rnd.Next(0, 9);
        this.y = Singleton.Instance.rnd.Next(0, 9);
    }

}