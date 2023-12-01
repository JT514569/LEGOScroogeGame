using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problems : MonoBehaviour
{
    public static int SolveProblems;
    public Text probText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string ptext = "Problems: " + SolveProblems;
        probText.text = ptext;
    }
}
