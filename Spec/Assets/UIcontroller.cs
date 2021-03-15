using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public GameObject g1info;
    public GameObject g2info;
    public GameObject g3info;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void G1InfoBoxEnable()
    {
        g1info.SetActive(true);
    }

    public void G2InfoBoxEnable()
    {
        g2info.SetActive(true);
    }

    public void G3InfoBoxEnable()
    {
        g3info.SetActive(true);
    }

    public void G1InfoBoxDisable()
    {
        g1info.SetActive(false);
    }

    public void G2InfoBoxDisable()
    {
        g2info.SetActive(false);
    }

    public void G3InfoBoxDisable()
    {
        g3info.SetActive(false);
    }
}
