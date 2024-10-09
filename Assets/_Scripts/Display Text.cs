using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    private GameObject ghost;
    public void ToggleText()
    {
        ghost = GameObject.Find("Ghost");
        ghost.SetActive(true);
    }
}

