using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.UI;
using UnityEngine.UI;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    //This is the handler of the main menu scene

    [SerializeField] Text PlayerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        if (PlayerDataHandle.Instance != null)
        {
            PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
        }
        else
        {
            Debug.LogWarning("PlayerDataHandle.Instance is null. Make sure it is initialized in the scene.");
        }
    }


    public void ExitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
