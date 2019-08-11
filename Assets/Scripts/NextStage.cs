using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextStage : MonoBehaviour
{
    public GameObject button; 
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindGameObjectWithTag("NextStage");
        button.GetComponent<Image>().enabled = true;
        button.GetComponent<Button>().enabled = true;
        button.transform.GetChild(0).gameObject.SetActive(true);
        Debug.Log("poop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
