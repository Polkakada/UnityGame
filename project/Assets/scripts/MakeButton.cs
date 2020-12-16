using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        GameObject hero = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void AttachCallback(string button)
    {

        
        

    }
}
