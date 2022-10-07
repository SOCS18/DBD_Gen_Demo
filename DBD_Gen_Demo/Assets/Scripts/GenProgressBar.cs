using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenProgressBar : MonoBehaviour
{
    public GenRepairController genRepControl;
    public GeneratorStats genStats;

    public Slider genProgressBar;

    // Start is called before the first frame update
    void Start()
    {
        genProgressBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (genRepControl.isNearGen)
        {
            if (Input.GetKey(KeyCode.E))
            {
                genProgressBar.value += genStats.genRepairSpeed;
            }
        }
        
    }
}
