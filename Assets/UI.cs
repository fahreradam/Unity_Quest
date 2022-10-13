using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject ball;
    TextMeshProUGUI score_value;
    TextMeshProUGUI high_value;
    TextMeshProUGUI respawn_time;
    TextMeshProUGUI Respawn_text;
    public float current_score = 0;
    float max_score = 0;
    float time = 2;
    // Start is called before the first frame update
    void Start()
    {
        Respawn_text = transform.Find("Respawn").GetComponent<TextMeshProUGUI>();
        respawn_time = transform.Find("respawn_time").GetComponent<TextMeshProUGUI>();
        score_value = transform.Find("score_value").GetComponent<TextMeshProUGUI>();
        high_value = transform.Find("best_value").GetComponent<TextMeshProUGUI>();

        respawn_time.enabled = false;
        Respawn_text.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (ball.GetComponent<ball>().respawn)
        {
            time -= Time.deltaTime;

            if (current_score >= max_score)
                high_score();
            respawn_time.enabled = true;
            Respawn_text.enabled = true;
            respawn_time.text = (Mathf.Round(time * 100) / 100).ToString();
            ;

            if (time <= 0)
            {
                ball.GetComponent<ball>().respawn = false;
                time = 2;
                respawn_time.enabled = false;
                Respawn_text.enabled = false;
                current_score = 0;
            }
        }
        if (ball.GetComponent<ball>().respawn == false)
        {
            current_score += Time.deltaTime * 10;
        }
        score();


        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void score()
    {
        score_value.text = ((int)current_score).ToString();
    }
    void high_score()
    {
        max_score = (int)current_score;
        high_value.text = max_score.ToString();
    }
}
