using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public LayerMask IgnoreMe;
    public Rigidbody2D rb;
    public float speed;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public GameObject player_look;
    public GameObject empty_obj;
    public Camera top_down_cam;
    public DistanceJoint2D distance_joint;
    public GameObject find_pos;
    // Start is called before the first frame update
    void Start()
    {
        //top_down_cam = Camera.main;
        if (transform.name == "player_1")
        {
            player_look = GameObject.Find("player_2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player_look != null)
        {
            float mid_point = Vector2.Distance(transform.position, player_look.transform.position);
            empty_obj.transform.LookAt(player_look.transform.position);
            find_pos.transform.rotation = empty_obj.transform.rotation;
            find_pos.transform.position = transform.position + transform.forward * mid_point;
            print(mid_point);
            //find_pos.transform.position = transform.position + Vector3.forward * mid_point;

            
            Debug.DrawRay(transform.position, empty_obj.transform.forward, Color.red);
        }
        if (Input.GetKey(up))
        {
            rb.AddForce(Vector2.up * speed * Time.deltaTime * 100);
        }
        if (Input.GetKey(down))
        {
            rb.AddForce(Vector2.down * speed * Time.deltaTime * 100);
        }
        if (Input.GetKey(left))
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime * 100);
        }
        if (Input.GetKey(right))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime * 100);
        }
    }
}
