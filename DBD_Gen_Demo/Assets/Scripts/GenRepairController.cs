using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRepairController : MonoBehaviour
{
    [HideInInspector] public bool isNearGen1;
    [HideInInspector] public bool isNearGen2;
    [HideInInspector] public bool isReparingGen;

    public GameObject repairGenText;

    // Update is called once per frame
    void Update()
    {
        if (isNearGen1 || isNearGen2)
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
        switch (other.gameObject.tag)
        {
            case "GenTrigger":
                isNearGen1 = true;
                break;
            case "GenTrigger2":
                isNearGen2 = true;
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "GenTrigger":
                isNearGen1 = false;
                break;
            case "GenTrigger2":
                isNearGen2 = false;
                break;
        }
    }
}
