using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float CompletionTime;
    private float Timer = 0.0f;
    public Text TimeLeft;
    PlayerScript PlayerRef;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRef = FindObjectOfType<PlayerScript>();
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

        if (PlayerRef.HP <= 0)
        {
            // Lose Here
            print("You Lost!");
        }

        if (PlayerRef.GetHasDiamond())
        {
            // Win Here
            print("You Won!");
        }
    }
}
