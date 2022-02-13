using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Player"))
        {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
        }
        if(this.gameObject.name.Contains("Arch"))
        {
        GameManager.Instance.onArchEntered(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}
