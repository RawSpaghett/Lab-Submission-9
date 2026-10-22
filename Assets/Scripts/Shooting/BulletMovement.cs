using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private BulletLogic bulletLogic;
    private float bulletSpeed = 5f;

    void Awake()
    {
        GameObject tmp = GameObject.Find("Player");
        bulletLogic = tmp.GetComponent<BulletLogic>();
    }

    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            bulletLogic.Release(this.gameObject);
        }

        if (collision.gameObject.name == "TopOfScreen")
        {
            bulletLogic.Release(this.gameObject);
        }
    }
}
