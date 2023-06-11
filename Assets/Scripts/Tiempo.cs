using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public Text texto;
    public float Tiemp = 0;

    // Update is called once per frame
    void Update()
    {
        Tiemp -= Time.deltaTime;
        texto.text = "" + Tiemp.ToString("f2");
        
        if (Tiemp < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
