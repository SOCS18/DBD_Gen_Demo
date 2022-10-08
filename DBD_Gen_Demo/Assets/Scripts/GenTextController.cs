using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GenTextController : MonoBehaviour
{
    public GeneratorsStatus genStatus;

    public TMP_Text numGenText;
    
    // Start is called before the first frame update
    void Start()
    {
        numGenText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        numGenText.text = "Generators: " + genStatus.numGenerators;
    }
}
