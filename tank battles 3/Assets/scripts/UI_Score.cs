using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI_Score : MonoBehaviour
{
    Label score1;
    Label score2;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        score1 = root.Q<Label>("score1");
        score2 = root.Q<Label>("score2");
    }

    void Update()
    {
        score1.text = GameManagerr.Instance.score1.ToString();
        score2.text = GameManagerr.Instance.score2.ToString();
    }
}