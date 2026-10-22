using UnityEngine;
using UnityEngine.InputSystem;

public class BulletLogic : MonoBehaviour
{
    private PlayerInputScript playerInput;

    private bool sameShot;

    void Awake()
    {
        playerInput = GetComponent<PlayerInputScript>();
    }
    void Update()
    {
        ShootLogic();
    }

    void ShootLogic()
    {
        if (playerInput.shoot)
        {
            if (!sameShot)
            {
                sameShot = true;
                Shoot();
                return;
            }
        }
        else { sameShot = false; }
    }

    void Shoot()
    {
        Borrow();
    }

    void Borrow()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
        }
    }

    public void Release(GameObject bullet)
    {
        bullet.SetActive(false);
    }
}
