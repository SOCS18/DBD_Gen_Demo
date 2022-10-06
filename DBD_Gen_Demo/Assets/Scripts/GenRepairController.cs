using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRepairController : MonoBehaviour
{
    public GeneratorStats generatorStats;

    public bool isNearGen;
    public bool isReparingGen;

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
            }
            else
            {
                isReparingGen = false;
            }
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
