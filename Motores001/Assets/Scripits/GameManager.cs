using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;
        hud.text = $"Moedas restantes: {restantes}";

    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes}";
        source.PlayOneShot(clipMoeda);

        if (restantes <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "PARAB�NS!:)";
            source.Stop();
            source.PlayOneShot(clipVitoria);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
