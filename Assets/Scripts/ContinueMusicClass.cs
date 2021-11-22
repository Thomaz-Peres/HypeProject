using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusicClass : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

}
