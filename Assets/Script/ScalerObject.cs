using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalerObject : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Start()
    {
        slider.value = transform.localScale.x;
    }

    public void SetScale(float value)
    {
        transform.localScale = new Vector3(value, transform.localScale.y, value);
    }
}
