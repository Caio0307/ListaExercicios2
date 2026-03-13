using Unity.VisualScripting;
using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    /*
     Exercício 7 – Vida Restante do Personagem
Um personagem possui 150 pontos de vida.
Durante uma batalha ele recebeu os seguintes danos:
• Ataque do inimigo 1: 20
• Ataque do inimigo 2: 35
• Ataque do inimigo 3: 15
Problema:
Crie variáveis para a vida inicial e para os danos recebidos.
Calcule quanta vida resta ao personagem e exiba o resultado no console usando print()
     */
    int vida = 150;





    void Start()
    {
        int ataque1 = 20;
        int ataque2 = 35;
        int ataque3 = 15;
        int vidaRestante = vida - ataque1 - ataque2 - ataque3;

        print("Você iniciou a fase com um total de 150 pontos de vida.Mas você sofreu 3 ataques!.");
        print("No primeiro ataque você sofreu " + (ataque1) + " de dano.");        
        print("No segundo ataque você sofreu " + (ataque2) + " de dano.");
        print("E no último ataque você sofreu " + (ataque3) + " de Dano.");
        print("Sua pontuação de vida atual é de: " + (vidaRestante) + " Pontos de vida!.");
    }

   
    void Update()
    {
        
    }
}
