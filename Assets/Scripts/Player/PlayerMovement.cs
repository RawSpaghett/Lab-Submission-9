using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInputScript playerInput;


    [SerializeField] private float moveSpeed = 4f;

    void Awake()
    {
        playerInput = GetComponent<PlayerInputScript>();
    }
    void Update()
    {
        //because vector3.right is (1,0,0), when you multiply it by -1, it is now sending you left, the key player is playerInput.moveDirection, as that is passing your
        //left, right, or no movement value
        transform.Translate(Vector3.right * playerInput.moveDirection * moveSpeed * Time.deltaTime);
    }
}
