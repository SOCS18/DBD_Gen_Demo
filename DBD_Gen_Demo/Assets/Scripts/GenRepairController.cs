using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenRepairController : MonoBehaviour
{
    public GenProgressBar progressBar;
    public GeneratorStats generatorStats;

    public bool isNearGen;
    public bool isReparingGen;

    public GameObject repairGenText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearGen)
        {
            if (Input.GetKey(KeyCode.E))
            {
                isReparingGen = true;
                progressBar.genProgressBar.value += generatorStats.genRepairSpeed;
            }
            else
            {
                isReparingGen = false;
            }
            repairGenText.SetActive(true);
        }
        else
        {
            repairGenText.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GenTrigger")
            isNearGen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GenTrigger")
            isNearGen = false;
    }
}
