﻿using UnityEditor;
using UnityEngine;

/// <summary>
/// Automnatically set the layer of imported models to 10 (Chara)
/// </summary>
public class SetLayerPostprocessor : AssetPostprocessor
{
    void OnPostprocessModel(GameObject g)
    {
        g.layer = 10;
        foreach (var child in g.GetComponentsInChildren<GameObject>(true))
            child.layer = 10;
    }
}