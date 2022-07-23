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
    }

    // Update is called once per frame
    void Update()
    {

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
