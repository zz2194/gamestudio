using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This is private, so that we can show an error if its not set up yet
    private static GameManager staticInstance;

    public float numofPoints;
    public GameObject[] arches;

    public static GameManager Instance
    {
        get
        {
            // If the static instance isn't set yet, throw an error
            if (staticInstance is null)
            {
                Debug.LogError("Game Manager is NULL");
            }

            return staticInstance;
        }
    }

    private void Awake()
    {
        // Set the static instance to this instance
        staticInstance = this;
    }

    public void onArchEntered(GameObject arch)
    {
        Debug.Log(System.Array.IndexOf(arches,arch));
    }
}
