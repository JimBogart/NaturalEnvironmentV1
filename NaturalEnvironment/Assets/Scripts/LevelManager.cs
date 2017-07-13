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


    public void nextScene()
    {

        int y = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(y + 1);
    }

    public void loadScene6()
    {

        SceneManager.LoadScene(6);
    }


    public void loadScene7()
    {

        SceneManager.LoadScene(7);
    }



    public void loadScene8()
    {

        SceneManager.LoadScene(8);
    }


    public void backScene()
    {

        int y = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(y - 1);
    }


}
