using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ws_paddles;
    public GameObject[] ad_paddles;
    public float rotation = 9;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            foreach (GameObject p in ws_paddles)
            {
                p.transform.localPosition += new Vector3(Mathf.Deg2Rad * rotation, 0, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey("s"))
        {
            foreach (GameObject p in ws_paddles)
            {
                p.transform.localPosition -= new Vector3(Mathf.Deg2Rad * rotation, 0, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey("a"))
        {
            foreach (GameObject p in ad_paddles)
            {
                p.transform.localPosition += new Vector3(0, 0, Mathf.Deg2Rad * rotation) * Time.deltaTime;
            }
        }
        if (Input.GetKey("d"))
        {
            foreach (GameObject p in ad_paddles)
            {
                p.transform.localPosition -= new Vector3(0, 0, Mathf.Deg2Rad * rotation) * Time.deltaTime;
            }
        }
    }



    private void FixedUpdate()
    {
        rotate();
    }

    void rotate()
    {
        transform.Rotate(rotation * Time.deltaTime, 0f , 0f, Space.World);
    }
}
