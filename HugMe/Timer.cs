using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;

    [SerializeField] Text recordText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        recordText.text = currentTime.ToString();
    }
}
