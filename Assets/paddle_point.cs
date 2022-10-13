using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_point : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball")
        {
            ui.GetComponent<UI>().current_score += 100;
        }

    }
}
