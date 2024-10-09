using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FlyingBook : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Transform Target;

    private bool bookActivated = false;

    public void ActivateBook()
    {
        bookActivated = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bookActivated)
        {
            transform.position = Target.transform.position + new Vector3(0, 2, 0);
            transform.RotateAround(Target.position, new Vector3(1, 0, 1), Speed * Time.deltaTime);        }
    }
}