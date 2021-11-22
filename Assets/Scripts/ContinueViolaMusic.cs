using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueViolaMusic : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("ViolaMusic").GetComponent<ViolaMusicClass>().PlayMusic();
    }
}
