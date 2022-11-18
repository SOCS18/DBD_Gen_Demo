using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorsStatus : MonoBehaviour
{
    public GameObject genParent;
    public GameObject[] generators;
    public float[] genHealth;
    public int numGenerators;

    public int maxHealth = 100;

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
        }
    }

    private void Update()
    {
        for (int i = 0; i < numGenerators; i++)
            genHealth[i] = Mathf.Clamp(genHealth[i], 0, maxHealth);
    }
}
