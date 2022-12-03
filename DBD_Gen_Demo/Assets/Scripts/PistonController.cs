using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonController : MonoBehaviour
{
    public GeneratorsStatus genStats;
    public bool[] pistonOn = { false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        genStats = GetComponent<GeneratorsStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < genStats.numGenerators; i++)
        {
            if (genStats.genHealth[i] >= 25)
                pistonOn[0] = true;

            if (genStats.genHealth[i] >= 50)
                pistonOn[1] = true;

            if (genStats.genHealth[i] >= 75)
                pistonOn[2] = true;
            
            if (genStats.genHealth[i] == 100)
                pistonOn[3] = true;
        }
    }
}
