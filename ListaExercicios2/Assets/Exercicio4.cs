using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio4 : MonoBehaviour
{
    /*Exercício 4 – Tempo de Missão
 Um jogador levou os seguintes tempos para completar três partes de uma missão:
• Parte 1: 12 minutos
• Parte 2: 18 minutos
• Parte 3: 9 minutos
Problema:
Crie variáveis para armazenar os tempos de cada parte.
Calcule o tempo total da missão e exiba o resultado no console usando print().
    */
    int part1 = 12;
    int part2 = 18;
    int part3 = 9;


    void Start()
    {
        int TempoTotal = part1 + part2 + part3;
        print("No geral, a missão durou " + (TempoTotal) + " minutos!");
        print("Você gastou " + (part1) + " minutos na parte 1. " + (part2) + " minutos na parte 2. e " + (part3) + " minutos na parte 3. ");
    }

    
    void Update()
    {
        
    }
}
