using UnityEngine;
using UnityEngine.UI;

public class PauseButtonScript : MonoBehaviour
{
    public PauseMenuScript pauseMenu;

    private void Start()
    {
        // Get the Button component attached to this GameObject
        Button pauseButton = GetComponent<Button>();

        // Add a listener to the button to call the PauseGame function when clicked
        pauseButton.onClick.AddListener(PauseGame);
    }

    private void PauseGame()
    {
        pauseMenu.PauseGame();
    }
}
