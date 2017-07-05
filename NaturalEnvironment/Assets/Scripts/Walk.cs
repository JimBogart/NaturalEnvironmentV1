using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    public GameObject model;
    public float walkSpeed;
    public float steps = 0;
    public float distanceToWalk;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (steps < distanceToWalk) { 
            model.transform.position += model.transform.TransformDirection(Vector3.back) * walkSpeed;
       
            steps++;

    } 

   else
        {

            model.GetComponent<Animation>().Play("Allosaurus_Idle");
        

        }


    

    }
}
