using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddStat(Slider slider)
    {
        if (slider.value < slider.maxValue)
        {
            slider.value += 1;
        }
    }
}
