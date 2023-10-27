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
                                                                                                //iki de�er aras�nda lineer bir ge�i� olu�turmak i�in kullan�l�r
                                                                                                //bir nesnenin bir konumdan di�erine veya bir de�erden ba�ka bir de�ere yumu�ak bir �ekilde ge�i�ini sa�lamak  i�in kullan��l�d�r
                                                                                                //Lerp, �zellikle animasyonlar, ge�i�ler, kameralar�n takip hareketleri ve daha pek �ok farkl� senaryoda kullan�l�r
        transform.position = newPos;
    }
}
