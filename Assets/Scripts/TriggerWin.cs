using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    public Manager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().name == "Player")
        {
            manager.Win();
        }
    }
}
