using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDelJocScript : MonoBehaviour
{

    [HideInInspector]
    public int puntuacio = 0;
    private int puntuacioMaxima = 0;

    // Update is called once per frame
    void Update()
    {

    }

    private void Start()
    {
        puntuacioMaxima = PlayerPrefs.GetInt("Maxim", 0);
    }

    public void Puntua(int quantitat)
    {

        puntuacio += quantitat;
        if(puntuacio > puntuacioMaxima)
        PlayerPrefs.SetInt("Maxim",puntuacio);
    }

    public void CarregaEscena(int nEscena)
    {
        SceneManager.LoadScene(nEscena, LoadSceneMode.Single);
    }

    public void Surt()
    {
#if UNITY_STANDALONE
    Application.Quit();

#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#endif

    }

}
