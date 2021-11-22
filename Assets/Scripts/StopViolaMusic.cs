using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopViolaMusic : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("ViolaMusic").GetComponent<ViolaMusicClass>().StopMusic();
    }
}
