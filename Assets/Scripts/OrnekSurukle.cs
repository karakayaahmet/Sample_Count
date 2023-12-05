using UnityEngine;

public class OrnekSurukle : MonoBehaviour
{
    public Rigidbody balonRigidbody;
    public GameObject hedefBalon;
    public AudioSource audioSource;

    private Vector3 baslangicPozisyon;

    void Start()
    {
        // Rigidbody, AudioSource bileþenlerini al
        balonRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        // Baþlangýç pozisyonunu kaydet
        baslangicPozisyon = transform.position;

        // Ses bitiþini algýlamak için bir metodun tetiklenmesini bekleyin

    }

    void Update()
    {
        // HedefBalon'un pozisyonundan kendi pozisyonunuzu çýkartýn
        Vector3 aradakiFark = hedefBalon.transform.position - transform.position;

        // Sürükleme iþlemini gerçekleþtir
        balonRigidbody.AddForce(aradakiFark);

        // Baþlangýç pozisyonuna dön

    }

    
}
