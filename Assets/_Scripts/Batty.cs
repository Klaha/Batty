using UnityEngine;
using UnityEngine.UI;

public class Batty : MonoBehaviour
{
    public Rigidbody2D rb2d;
    int fuerza;

    int contador;
    public Text cajaPuntuacion;

    int record;
    public Text cajaRecords;

    public GameObject gameOver;

    public AudioSource canalAudio;

    public AudioClip sonidoPuntos;
    public AudioClip sonidoMuerte;
    public AudioClip sonidoFuerza;

    // Start is called before the first frame update
    void Start()
    {
        fuerza = 5;
        contador = 0;
        record = PlayerPrefs.GetInt("RecordCache", 0);
        cajaRecords.text = record.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // (0,1) * fuerza.
            rb2d.velocity = Vector2.up * fuerza;
            canalAudio.PlayOneShot(sonidoFuerza);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        gameOver.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstaculo")){
            Destroy(gameObject);
            canalAudio.PlayOneShot(sonidoMuerte);
        } else
        {
            SumarPuntos();
        }
    }

    void SumarPuntos()
    {
        contador++;
        canalAudio.PlayOneShot(sonidoPuntos);
        cajaPuntuacion.text = contador.ToString();
        if(contador > record)
        {
            record = contador;

            PlayerPrefs.SetInt("RecordCache", contador);
            cajaRecords.text = record.ToString();
        }

    }
}
