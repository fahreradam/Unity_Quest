using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject floor;
    public bool respawn = false;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (respawn)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = pos;
        }
        if (respawn == false)
        {
            if (transform.position.magnitude - floor.transform.position.magnitude >= 15)
            {
                respawn = true;
                transform.position = new Vector3(0, 0, 0);
            }
            if (GetComponent<Rigidbody>().velocity.y <= -35)
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, -35, GetComponent<Rigidbody>().velocity.z);
        }
    }
}
