
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole_puzzle : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject hole_1;
    public GameObject bridge_1;
    public float distance;

    public IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "bridge_1")
        {
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            print("Collider Disabled");
            for (float i = 0; i <= 1; i += 0.1f)
            {
                bc.enabled = false;
                bridge_1.transform.position = Vector2.Lerp(bridge_1.transform.position, hole_1.transform.position, i);
                yield return new WaitForSeconds(0.1f);
            }
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(hole_1.transform.position, bridge_1.transform.position); 
    }
}
