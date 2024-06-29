using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    private bool hasScored = false; // Flag to track if score has been incremented

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3 && !hasScored)
        {
            logic.addScore(1);
            hasScored = true; // Set the flag to true after scoring
        }


    }
}
