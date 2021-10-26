using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadraoAnimado : MonoBehaviour
{


    [SerializeField]
    RawImage animatedImage;
    Rect _rect;


    [SerializeField]
    float animatedSpeed;

    [SerializeField]
    Vector2 animatedDirection;

    void Start()
    {
        _rect = animatedImage.uvRect;
    }

   
    void Update()
    {
        _rect.x += animatedDirection.x * animatedSpeed * Time.deltaTime;
        _rect.y += animatedDirection.y * animatedSpeed * Time.deltaTime;
        animatedImage.uvRect = _rect;
    }
}
