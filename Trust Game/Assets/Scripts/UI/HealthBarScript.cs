using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    private const float MAXHEALTH = 100.0f;
    private Image HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = FindObjectOfType<PlayerScript>().HP / MAXHEALTH;
    }
}
