using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    public GameObject model;
    public float xRotation;
    public float yRotation;

	// Use this for initialization
	void Start () {
	
	}
	
    public void tailHeavyRotate()
    {


        model.transform.Rotate(new Vector3(xRotation, yRotation));
    }

    public void frontHeavyRotate()
    {


        model.transform.Rotate(new Vector3(-xRotation, yRotation));
    }

}
