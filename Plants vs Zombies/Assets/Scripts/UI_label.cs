using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_label : MonoBehaviour
{
    public Sun suns;
    public UnityEngine.UI.Text label;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Suns: " + suns.sun;
    }
}
