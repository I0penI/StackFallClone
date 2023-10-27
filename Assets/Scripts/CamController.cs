using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform ball;

    private Vector3 offset;
    public float smoothSpeed;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed); //LERP
                                                                                                //iki deðer arasýnda lineer bir geçiþ oluþturmak için kullanýlýr
                                                                                                //bir nesnenin bir konumdan diðerine veya bir deðerden baþka bir deðere yumuþak bir þekilde geçiþini saðlamak  için kullanýþlýdýr
                                                                                                //Lerp, özellikle animasyonlar, geçiþler, kameralarýn takip hareketleri ve daha pek çok farklý senaryoda kullanýlýr
        transform.position = newPos;
    }
}
