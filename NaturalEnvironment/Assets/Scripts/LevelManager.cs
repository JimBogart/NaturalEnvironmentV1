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

    public void loadScene3()
    {

        SceneManager.LoadScene(3);
    }

    public void loadScene1()
    {

        SceneManager.LoadScene(1);
    }

    public void loadScene2()
    {

        SceneManager.LoadScene(2);
    }

    public void loadScene4()
    {

        SceneManager.LoadScene(4);
    }

    public void loadScene5()
    {

        SceneManager.LoadScene(5);
    }


}
