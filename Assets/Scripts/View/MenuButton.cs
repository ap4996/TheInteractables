using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPopup;
    public Button button;

    private void Start()
    {
        SetButton();
    }

    private void SetButton()
    {
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(ButtonDelegate);
    }

    private void ButtonDelegate()
    {
        menuPopup.SetActive(true);
    }
}
