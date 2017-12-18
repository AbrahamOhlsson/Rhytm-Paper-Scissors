using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject player;

    private float playerDis;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        Distance(playerDis);

        //If player is close
		if(playerDis <= 100)
        {
            //Show diffrent attacks


            //If player is at attack range
            if(playerDis <= 50)
            {

            }
        }
	}

    public void Distance(float dis)
    {

    }

}
