using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    // This field can be accesed through our singleton instance,
    // but it can't be set in the inspector, because we use lazy instantiation
    public int number;
    public System.Random rnd = new System.Random();
    public int result;
	public bool calculInProgress;
	public int life = 3;
	public int score = 0;

	// Static singleton instance
	private static Singleton instance;

    // Static singleton property
    public static Singleton Instance
	{
		// Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
		// otherwise we assign instance to a new component and return that

		get { return instance ?? (instance = new GameObject("Singleton").AddComponent<Singleton>());}
    }

}