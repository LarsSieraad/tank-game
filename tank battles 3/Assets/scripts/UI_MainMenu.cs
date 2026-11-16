using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    Button buttonStart;
    Button buttonQuit;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        buttonStart = root.Q<Button>("start");
        buttonQuit = root.Q<Button>("quit");

        buttonStart.clicked += OnStartClicked;
        buttonQuit.clicked += OnQuitClicked;

    }

    void OnStartClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void OnQuitClicked()
    {
        
        Application.Quit();
    }



}
