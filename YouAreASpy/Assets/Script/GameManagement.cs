using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace GlobalDatas
{
    public class GameManagement : MonoBehaviour
    {

        static private float timer = 5.0f;
        static private int level = 1;
        static private int score = 0;
        static private int life = 5;
        static public System.Random rnd = new System.Random();

        //Getteur Setteur
        static public float Timer
        {
            get  { return timer; }
            set { timer = value; }
        }

        static public int Level
        {
            get { return level; }
            set { level = value; }
        }

        static public int Score
        {
            get { return score; }
            set { score = value; }
        }

        static public int Life
        {
            get { return life; }
            set { life = value; }
        }


        //Méthode Utile

        //Méthode pour changer les levels
        static public void ChangeLevel()
        {
            if (Score >= (level * 20))
            {
                Level = Level + 1;
                if (Timer != 0.5f)
                    Timer -= 0.2f;
            }    
        }

        //Check si le joeur a encore le droit à l'erreur
        //TODO => au lieu de return -1 on Load la Scene de fin de jeu avec possibilité de rejouer
        static public void checkDeath()
        {
            if (Life < 1)
            {
                SceneManager.LoadScene("endGame");
            }
        }


    }
}

