using UnityEngine;

public class Exerciciio5 : MonoBehaviour
{
    /*
     Exercício 5 – Coleta de Moedas
 Durante uma fase o jogador coletou:
 • 12 moedas de bronze (valor 1)
 • 8 moedas de prata (valor 5)
 • 3 moedas de ouro (valor 10)
 Problema:
 Crie variáveis para as quantidades e valores das moedas.
 Calcule o valor total coletado e imprima no console usando print().
     */

    int MoedaBronze = 1;
    int MoedaPrata = 5;
    int MoedaOuro = 10;

    

    
       
    


    void Start()
    {
        int MoedaBronzePega = 12;
        int MoedaPrataPega = 8;
        int MoedaOuroPega = 3;
        int totalMoedas = MoedaBronzePega + MoedaPrataPega + MoedaOuroPega;
        int valorTotalMoedas = MoedaBronzePega * MoedaBronze + MoedaPrataPega * MoedaPrata + MoedaOuroPega * MoedaOuro;

        print("Parabéns, nessa fase você coletou: " + (MoedaBronzePega) + " moedas de bronze " + (MoedaPrataPega) + " moedas de prata e " + (MoedaOuroPega) + " moedas de ouro!");
        print("No total, você pegou :" + (totalMoedas) + " moedas!, seu saldo final é de : " + (valorTotalMoedas));










    }

    
    void Update()
    {
        
    }
}
