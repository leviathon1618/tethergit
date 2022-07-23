using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle_track_puzzle : MonoBehaviour
{
    public GameObject track_circle1;
    public GameObject circle_hole;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(track_circle1.transform.position, circle_hole.transform.position) <= 1)
        {
            print("Circle");
            // Do stuff
        }
    }
}
