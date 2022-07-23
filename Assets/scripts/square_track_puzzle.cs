using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_track_puzzle : MonoBehaviour
{

    public GameObject track_square1;
    public GameObject square_hole;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(track_square1.transform.position, square_hole.transform.position) <= 1)
        {
            print("Yes");
            // Do stuff
        }
    }
}
