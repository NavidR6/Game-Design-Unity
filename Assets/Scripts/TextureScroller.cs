using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    private Material material;
    public float parallaxEffect;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.mainTextureOffset += new Vector2(parallaxEffect / 100, 0);
    }
}
