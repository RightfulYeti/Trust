using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float CompletionTime;
    private float Timer = 0.0f;
    public Text TimeLeft;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > 1.0f)
        {
            CompletionTime--;
            GameObject.Find("TimerText").GetComponent<Text>().text = CompletionTime.ToString();
            Timer = 0;
        }
    }
}
