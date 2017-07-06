using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    public GameObject model;

	// Use this for initialization
	void Start () {
	
	}
	
    public void rightClick()
    {


        model.transform.Rotate(new Vector3(10, 10));
    }
	
}
