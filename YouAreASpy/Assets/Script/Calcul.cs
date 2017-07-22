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
         
        this.x = GameManagement.Instance.rnd.Next(0, 9);
        this.y = GameManagement.Instance.rnd.Next(0, 9);
    }

    //Calcule l'opération et retourne le bon ou le mauvais résultats en fonction du besoin
    public void doCalcul(int x, int y)
    {

        
        
    }

}