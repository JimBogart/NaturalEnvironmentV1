using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    public GameObject model;
    public float walkSpeed;
    public float steps = 0;
    public float count = 0;
    public float timeToChangeAnimation;
    public float distanceToWalk;
    public string chosenAnimation;


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

            if (count <= timeToChangeAnimation)
            {

                count++;
                model.GetComponent<Animation>().Play("Allosaurus_Idle");
            }

            else if(count > 800)
            {

                count = 0;
            }

            else
            {

                count++;
                model.GetComponent<Animation>().Play(chosenAnimation);

            }

        }


    

    }
}
