using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexChanger : MonoBehaviour
{
    private MeshFilter filter;
    private Vector3[] vertices;
    private void Awake()
    {
        filter = GetComponent<MeshFilter>();
        vertices = filter.mesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {

        }
    }
    private void Update()
    {

    }

}
