using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class homebase : MonoBehaviour
{
    public int progress = 0;
    public List<GameObject> ship_list = new List<GameObject>();
    public List<bool> parts_found = new List<bool>();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        string test = collision.transform.name;
        string[] split_name = test.Split('_');
<<<<<<< Updated upstream
        int number = Convert.ToInt32(split_name[1]);
        if (number.GetType() == typeof(int))
        {
            switch (number)
            {
                case 0:
                    ship_list.Insert(0,collision.gameObject);
                    parts_found[0] = true;
                    break;

                default:
                    break;
            }
        }
        
=======
        // if ((int) split_name[1]==true)
        //{

        //}
        switch (Convert.ToInt32( split_name[1]))
        {
            case 1:

                break;

           default:
                break;
        }
>>>>>>> Stashed changes

        if (collision.transform.name == "")
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
