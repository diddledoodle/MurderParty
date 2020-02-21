using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects interactive elements the player is looking at
/// </summary>
public class InteractiveObject : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detective interactives")]
    [SerializeField]
    private Transform raycastOrigin;

    [Tooltip("How far from raycast Origin will we search for interactive elements")]
    [SerializeField]
    private float maxRange = 5.0f;
    private Vector3 raycastDirection;
}
                          