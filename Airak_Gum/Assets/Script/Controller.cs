using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public GameObject crab;
    private static int score = 0;
    private static bool isCollect;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

        isCollect = false;
        for (int i = 0; i < 3; i++)
        {
            Instantiate(crab);
        }
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (Time.timeScale == 1)
            {
                // pause game
                Time.timeScale = 0;
            }
            else
            {
                // resume
                Time.timeScale = 1;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isCollect)
        {
            scoreText.text = "Collected crabs: " + score.ToString();
            isCollect = false;
            StartCoroutine(Wait());
        }
    }

    public void collectCrab()
    {
        score += 1;
        isCollect = true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        Instantiate(crab);
    }
}
