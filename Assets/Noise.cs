using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour
{
    public float power = 3f;
    public float scale = 1f;
    public float timeScale = 1f;

    private float xOffset;
    private float yOffset;
    private MeshFilter mf;

    private WaitForSeconds ws = new WaitForSeconds(0.05f);

    private void Start()
    {
        mf = GetComponent<MeshFilter>();
        StartCoroutine(MakeNoise());
    }
    private void Update()
    {
        xOffset += Time.deltaTime * timeScale;
        yOffset += Time.deltaTime * timeScale;
    }
    IEnumerator MakeNoise()
    {
        while (true)
        {
            Vector3[] vertecies = mf.mesh.vertices;
            for (int i = 0; i < vertecies.Length; i++)
            {
                Vector3 vector = vertecies[i];
                float xCord = vector.x * scale * xOffset;
                float yCord = vector.z * scale * yOffset;

                vertecies[i].y = Mathf.PerlinNoise(xCord, yCord) * power;
            }
            mf.mesh.vertices = vertecies;
            yield return ws;
        }

    }
}
