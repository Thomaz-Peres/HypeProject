using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    
  
    public void TelaEscolhaHome()
    {
        StartCoroutine("IndoTelaEscolha");
       
    }
    IEnumerator IndoTelaEscolha()
    {   
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Scene_Choice");
    }

    public void TelaGame()
    {
        SceneManager.LoadScene("Scene_Draw");
    }

    public void TelaEscolha()
    {
        SceneManager.LoadScene("Scene_Choice");
    }
}
