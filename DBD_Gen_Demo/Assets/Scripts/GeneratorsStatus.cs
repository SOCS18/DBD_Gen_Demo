using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorsStatus : MonoBehaviour
{
    public GameObject genParent;
    public GameObject[] generators;
    public float[] genHealth;
    private int numGenerators;

    // Start is called before the first frame update
    void Start()
    {
        genParent = GameObject.FindGameObjectWithTag("GenParent");
        numGenerators = genParent.transform.childCount;
        generators = new GameObject[numGenerators];
        genHealth = new float[numGenerators];

        for (int i = 0; i < numGenerators; i++)
        {
            generators[i] = genParent.transform.GetChild(i).gameObject;
            genHealth[i] = 0;
            genHealth[i] = Mathf.Clamp(genHealth[i], 0, 100);
        }
    }

    private void Update()
    {
        for (int i = 0; i < numGenerators; i++)
            genHealth[i] = Mathf.Clamp(genHealth[i], 0, 100);
    }
}
