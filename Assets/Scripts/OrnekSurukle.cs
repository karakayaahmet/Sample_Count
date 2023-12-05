using UnityEngine;

public class OrnekSurukle : MonoBehaviour
{
    public Rigidbody balonRigidbody;
    public GameObject hedefBalon;
    public AudioSource audioSource;

    private Vector3 baslangicPozisyon;

    void Start()
    {
        // Rigidbody, AudioSource bile�enlerini al
        balonRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        // Ba�lang�� pozisyonunu kaydet
        baslangicPozisyon = transform.position;

        // Ses biti�ini alg�lamak i�in bir metodun tetiklenmesini bekleyin

    }

    void Update()
    {
        // HedefBalon'un pozisyonundan kendi pozisyonunuzu ��kart�n
        Vector3 aradakiFark = hedefBalon.transform.position - transform.position;

        // S�r�kleme i�lemini ger�ekle�tir
        balonRigidbody.AddForce(aradakiFark);

        // Ba�lang�� pozisyonuna d�n

    }

    
}
