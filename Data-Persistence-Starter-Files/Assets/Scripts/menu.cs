using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{

    [SerializeField] InputField field;
    void Start()
    {
        
    }

    public void Play()
    {
        thewholepoint.Instance.currname = field.text;
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
