using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGlassesNew : MonoBehaviour
{
    public GameObject G1Obj;
    public GameObject G2obj;
    public GameObject G3obj;

    Button glass1Button;
    Button glass2Button;
    Button glass3Button;



    void Start()
    {
        glass1Button = GameObject.Find("Canvas/G1Button").GetComponent<Button>();
        glass2Button = GameObject.Find("Canvas/G2Button").GetComponent<Button>();
        glass3Button = GameObject.Find("Canvas/G3Button").GetComponent<Button>();

        glass1Button.onClick.AddListener(Glasses1Selected);
        glass2Button.onClick.AddListener(Glasses2Selected);
        glass3Button.onClick.AddListener(Glasses3Selected);
    }


    void Update()
    {
        
    }

    public void Glasses1Selected()
    {
        G1Obj.SetActive(true);
        G2obj.SetActive(false);
        G3obj.SetActive(false);
    }

    public void Glasses2Selected()
    {
        G1Obj.SetActive(false);
        G2obj.SetActive(true);
        G3obj.SetActive(false);
    }

    public void Glasses3Selected()
    {
        G1Obj.SetActive(false);
        G2obj.SetActive(false);
        G3obj.SetActive(true);
    }
}
