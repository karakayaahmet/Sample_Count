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
        // Rigidbody, AudioSource bileþenlerini al
        balonRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        // Baþlangýç pozisyonunu kaydet
        baslangicPozisyon = transform.position;
        hedefPozisyon = hedefBalon.transform.position;
        // Ses bitiþini algýlamak için bir metodun tetiklenmesini bekleyin

    }

    void FixedUpdate()
    {
        // HedefBalon'un pozisyonundan kendi pozisyonunuzu çýkartýn
        balonRigidbody.AddForce(hedefPozisyon);
        // Baþlangýç pozisyonuna dön

    }



    
}
