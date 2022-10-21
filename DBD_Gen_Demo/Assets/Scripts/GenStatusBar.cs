using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenStatusBar : MonoBehaviour
{
    public GeneratorsStatus genStatus;
    public GenRepairController genRepair;

    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (genRepair.isNearGen1)
            slider.value = genStatus.genHealth[0];
        if (genRepair.isNearGen2)
            slider.value = genStatus.genHealth[1];
    }
}
