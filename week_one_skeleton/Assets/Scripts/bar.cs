using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class bar : MonoBehaviour
{
    public Slider slider;

    public void reset(float maxVal) //reset 2 max health 
    {
        slider.maxValue = maxVal;
        slider.value = maxVal; 
    }

    public void setValue(float val) //public so we can call from other scripts 
    {
        slider.value = val; 
    }
}
