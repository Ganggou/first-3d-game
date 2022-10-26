using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    // Start is called before the first frame update
    private int coins;

    [SerializeField] Text collectText;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("in trigger");
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("compared");
            Destroy(other.gameObject);
            coins++;
            collectText.text = "coins: " + coins;
        }
    }
}
