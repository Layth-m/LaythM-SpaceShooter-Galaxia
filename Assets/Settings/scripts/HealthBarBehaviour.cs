using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    public Slider slider;
    private float healthvalue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
       // slider.minValue = 0; // Set minimum value
      //  slider.maxValue = 1000; // Set maximum values
    }
    public void Update()
    {
        if (slider.value != healthvalue)
        {
            slider.value = healthvalue;
        }
    }
    public void UpdateHealthBar(float currentValue)
    {
        healthvalue = currentValue;
        Debug.Log("Slider working" + healthvalue);
    }
  
}
