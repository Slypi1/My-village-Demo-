using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameItem : MonoBehaviour
{
    [SerializeField] private Renderer _mainRenderer;
    
    protected virtual void Repainting(bool isAvailable)
    {
        _mainRenderer.material.color = isAvailable ? Color.green : Color.red;
    }

    protected virtual void NormalColor()
    {
        _mainRenderer.material.color = Color.white;
    }
    
}
