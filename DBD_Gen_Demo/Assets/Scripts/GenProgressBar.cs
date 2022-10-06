using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenProgressBar : MonoBehaviour
{
    public Slider genProgressBar;

    // Start is called before the first frame update
    void Start()
    {
        genProgressBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
