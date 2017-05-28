using UnityEngine;
using System.Collections;
using System;
using GlobalDatas;
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
         
        this.x = GameManagement.rnd.Next(0, 9);
        this.y = GameManagement.rnd.Next(0, 9);
    }

    //Calcule l'opération et retourne le bon ou le mauvais résultats en fonction du besoin
    public int doCalcul(int x, int y, int op, bool correct)
    {
        int resultat;

        if (op == 0)
        {
            resultat = x + y;
        }
        else if (op == 1)
        {
            resultat = x - y;
        }
        else
        {
            resultat = x * y;
        }
        if (correct == false)
            return (resultat);
        else
        {
            //System.Random rnd = new System.Random();
            resultat = GameManagement.rnd.Next(0, 99);
            return resultat;
        }
    }

}