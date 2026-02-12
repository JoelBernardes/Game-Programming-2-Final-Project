using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private PlayerInputController _playerInputController;

    void Awake()
    {
        _playerInputController = GetComponent<PlayerInputController>();
    }

    void Update()
    {
        Vector3 positionChange = new Vector3(
            _playerInputController.MovementInputVector.x,
            0,
            _playerInputController.MovementInputVector.y)
            * Time.deltaTime
            * _speed;

        transform.position += positionChange;
    }
}
