using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject cleartext;
    public GameObject nextButton;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");
        cleartext.SetActive(true);
        nextButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
