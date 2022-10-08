using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenProgressBar : MonoBehaviour
{
    public GenRepairController genRepControl;
    public GeneratorsStatus genStatus;

    public float genRepairSpeed = 0.001f;

    // Update is called once per frame
    void Update()
    {
        if (genRepControl.isNearGen1)
        {
            if (Input.GetKey(KeyCode.Mouse0))
                genStatus.genHealth[0] += genRepairSpeed;
        }
        if (genRepControl.isNearGen2)
        {
            if (Input.GetKey(KeyCode.Mouse0))
                genStatus.genHealth[1] += genRepairSpeed;
        }
    }
}
