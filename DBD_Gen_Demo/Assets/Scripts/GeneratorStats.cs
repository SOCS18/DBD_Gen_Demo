using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GeneratorStats : MonoBehaviour
{
    public GenRepairController genRepairController;

    public GameObject genProgressBar;
    
    public float genRepair = 0f;
    public float genMaxRepair = 100f;
    public float genRepairSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        genProgressBar = transform.Find("GenCanvas").GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        genRepair = Mathf.Clamp(genRepair, 0, genMaxRepair);

        if (genRepairController.isNearGen)
        {
            genProgressBar.SetActive(true);
        }
        else
        {
            genProgressBar.SetActive(false);
        }
    }
}
