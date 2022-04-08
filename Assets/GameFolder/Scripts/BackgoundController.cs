using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundController : MonoBehaviour
{
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += Vector2.right * 0.5f * Time.deltaTime;
    }
}
