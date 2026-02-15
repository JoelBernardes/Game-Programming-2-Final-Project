using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    [SerializeField] private InputActionReference menuAction;
    [SerializeField] private GameObject inventoryUI;

    private void OnEnable()
    {
        menuAction.action.started += OnPressed;
        menuAction.action.canceled += OnReleased;
        menuAction.action.Enable();
    }
    private void OnDisable()
    {
        menuAction.action.started -= OnPressed;
        menuAction.action.canceled -= OnReleased;
        menuAction.action.Disable();
    }

    private void OnPressed(InputAction.CallbackContext context)
    {
        inventoryUI.SetActive(true);
    }

    private void OnReleased(InputAction.CallbackContext context)
    {
        inventoryUI.SetActive(false);
    }
}
