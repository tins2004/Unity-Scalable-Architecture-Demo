using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    [Header("Buttons")]
    [SerializeField] private Button forwardButton;
    [SerializeField] private Button backButton;
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    [SerializeField] private Button undoButton;
    [SerializeField] private Button redoButton;

    private void Start()
    {
        forwardButton.onClick.AddListener(OnForwardClick);
        backButton.onClick.AddListener(OnBackClick);
        leftButton.onClick.AddListener(OnLeftClick);
        rightButton.onClick.AddListener(OnRightClick);
        undoButton.onClick.AddListener(OnUndoClick);
        redoButton.onClick.AddListener(OnRedoClick);
    }

    private void RunPlayerCommand(PlayerController playerController, Vector3 movement)
    {
        if (playerController == null)
            return;

        if (playerController.IsValidMove(movement))
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(playerController, movement));
        }
    }

    private void OnForwardClick()
    {
        RunPlayerCommand(_playerController, Vector3.forward);
    }

    private void OnBackClick()
    {
        RunPlayerCommand(_playerController, Vector3.back);
    }

    private void OnLeftClick()
    {
        RunPlayerCommand(_playerController, Vector3.left);
    }

    private void OnRightClick()
    {
        RunPlayerCommand(_playerController, Vector3.right);
    }

    private void OnUndoClick()
    {
        CommandInvoker.UndoCommand();
    }

    private void OnRedoClick()
    {
        CommandInvoker.ReduCommand();
    }
}
