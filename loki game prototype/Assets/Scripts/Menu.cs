using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Canvas MainCanvas;
    public Canvas DifficultyCanvas;
    public Canvas AboutCanvas;
    void Awake()
    {
        DifficultyCanvas.enabled = false;
        AboutCanvas.enabled = false;
    }
    public void DifficultyOn()
    {
        DifficultyCanvas.enabled = true;
        MainCanvas.enabled = false;
        AboutCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        DifficultyCanvas.enabled = false;
        MainCanvas.enabled = true;
        AboutCanvas.enabled = false;
    }
    public void AboutOn()
    {
        AboutCanvas.enabled = true;
        DifficultyCanvas.enabled = false;
        MainCanvas.enabled = false;
    }
    public void ChangeScene(int index)
    {
        Application.LoadLevel(index);

    }
}

