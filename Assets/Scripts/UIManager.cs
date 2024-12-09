using UnityEngine;
using UnityEngine.UIElements;


public class UIManager : MonoBehaviour
{
    [SerializeField] private UIDocument uIDocument;
    [SerializeField] private VisualElement visualElement;


    private void OnEnable()
    {
        visualElement = uIDocument.rootVisualElement;
        Button startBtn = visualElement.Q<Button>("startbtn");
        startBtn.clicked += () => Debug.Log("Start Button Clicked ");

    }


}


