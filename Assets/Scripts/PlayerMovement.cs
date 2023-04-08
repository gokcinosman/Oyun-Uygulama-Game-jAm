using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // oyuncunun hareket hızı

    Rigidbody2D rb; // oyuncunun Rigidbody bileşeni

    Vector2 movement; // oyuncunun hareket vektörü

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // oyuncunun Rigidbody bileşenini alın
    }

    void Update()
    {
        // oyuncunun hareketi için girişleri okuyun
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // oyuncunun hareketi için fiziksel hesaplamalar yapın
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

}
