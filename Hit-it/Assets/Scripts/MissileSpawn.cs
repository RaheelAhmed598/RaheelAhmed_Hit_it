using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawn : MonoBehaviour
{
    
    public GameObject missile;
    // the missile that spaceship have from 1 to 10
    public int missileCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        missileSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        //getting the user input for the fire the missile 
        //and counting the missile that we have 
        if(Input.GetKeyDown(KeyCode.Space) && missileCount < 10)
        {
            missileCount++;
            missileSpawn();
        }
    }
    //Clones the object original and returns the clone.
    void missileSpawn()
    {
        Instantiate(missile, transform.position, transform.rotation);
    }
}
