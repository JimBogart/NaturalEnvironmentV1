using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


    public void loadSkullScene(){

		SceneManager.LoadScene (2);
		print ("clicked skull");
	}


	public void loadModelScene(){

		SceneManager.LoadScene (1);
		print ("clicked model");


	}

    public void loadMainScene()
    {

        SceneManager.LoadScene(0);

    }

    public void loadSkullDetailScene()
    {

        SceneManager.LoadScene(3);
    }

    public void loadEyeDetailScene()
    {

        SceneManager.LoadScene(1);
    }

    public void loadNostrilDetailScene()
    {

        SceneManager.LoadScene(2);
    }
}
