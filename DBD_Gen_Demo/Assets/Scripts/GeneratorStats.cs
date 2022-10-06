using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorStats : MonoBehaviour
{
    public GenRepairController genRepairController;
    
    public GameObject genProgressBarObj;
    
    public float genRepair = 0f;
    public float genMaxRepair = 100f;
    public float genRepairSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        genRepair = Mathf.Clamp(genRepair, 0, genMaxRepair);

        if (genRepairController.isNearGen)
        {
            genProgressBarObj.SetActive(true);
        }
        else
        {
            genProgressBarObj.SetActive(false);
        }
    }
}
