using UnityEngine;

public class Ogret : MonoBehaviour
{
    public Rigidbody balonRigidbody;
    public GameObject hedefBalon;
    public AudioSource audioSource;

    public Vector3 baslangicPozisyon;
    public Vector3 hedefPozisyon;

    public int say = 0;

    public int dongu = 0;


    void Start()
    {
        // Rigidbody, AudioSource bile�enlerini al
        balonRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        // Ba�lang�� pozisyonunu kaydet
        baslangicPozisyon = transform.position;
        hedefPozisyon = hedefBalon.transform.position;
        // Ses biti�ini alg�lamak i�in bir metodun tetiklenmesini bekleyin

    }

    void FixedUpdate()
    {
        // HedefBalon'un pozisyonundan kendi pozisyonunuzu ��kart�n
        balonRigidbody.AddForce(hedefPozisyon);
        // Ba�lang�� pozisyonuna d�n

    }



    
}
