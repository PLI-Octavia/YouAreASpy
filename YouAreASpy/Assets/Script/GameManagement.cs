using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


    public class GameManagement : MonoBehaviour
    {
        
        private int score = 0;
        public System.Random rnd = new System.Random();
        private static GameManagement instance;
        private GameManagement() { }
        public int result;

        //Getteur Setteur
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

       

        public static GameManagement Instance
        {
            get
            {
                if (instance == null)
                {
                Debug.Log("dadad");
                    instance = new GameManagement();
                }
                return instance;
            }
        }
            
    }