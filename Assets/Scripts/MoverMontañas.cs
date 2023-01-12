using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMontañas : MonoBehaviour
{
    [SerializeField] Vector2 velocidad, offset;
    [SerializeField] Material material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = velocidad * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
