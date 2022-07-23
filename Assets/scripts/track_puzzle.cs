using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_puzzle : MonoBehaviour
{

    public GameObject track_1a;
    public GameObject track_1b;
    public GameObject track_1c;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.transform.name == "player_1") ||  (collision.transform.name == "player_2")) { } 
    }

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
