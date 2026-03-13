using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    /*
     Exercício 3 – Consumo de Mana
 Um mago possui 100 de mana.
 Ele utilizou três magias:
 • Bola de fogo: 30 de mana
 • Raio elétrico: 20 de mana
 • Escudo mágico: 25 de mana
 Problema:
 Crie variáveis para a mana inicial e para o custo de cada magia.
 Calcule quanta mana resta após lançar todas as magias e mostre no console usando print().
    */
    int ManaInicial = 100;
    int BolaFogo = 30;
    int RaioEletric = 20;
    int Escudo = 25;








    void Start()
    {
        int ManaRest = ManaInicial - BolaFogo - RaioEletric - Escudo;
        print("Você acabou de utilizar 1 bola de fogo, 1 raio elétrico e 1 escudo mágico. lhe-restou apenas " + (ManaRest) + " de mana");



    }

    
    void Update()
    {
        
    }
}
