using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenRepairController : MonoBehaviour
{
    [HideInInspector] public bool isNearGen;
    [HideInInspector] public bool isReparingGen;

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
                isReparingGen = true;
            else
                isReparingGen = false;

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
