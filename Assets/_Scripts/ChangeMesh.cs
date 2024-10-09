using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class ChangeMesh : MonoBehaviour
{
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private Mesh newMesh;


    public void SetNewMesh()
    {
        meshFilter.mesh = newMesh;
    }
}
