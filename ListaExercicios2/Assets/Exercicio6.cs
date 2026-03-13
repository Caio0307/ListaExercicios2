using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    /*
    Exercício 6 – Velocidade do Personagem
 Um personagem percorreu 120 unidades de distância em 10 segundos.
 Problema:
 Crie variáveis para distância e tempo.
 Calcule a velocidade média do personagem usando a fórmula:
 velocidade = distancia / tempo
 Mostre o resultado no console usando print().
     */
    int distancia = 120;
    int tempo = 10;
  

    




    void Start()
    {
        int velocidade = distancia / tempo;

        print("Você correu 120m em 10 segundos!. sua velocidade média foi de: " + (velocidade)+ "Km/h.");



    }

    
    void Update()
    {
        
    }
}
