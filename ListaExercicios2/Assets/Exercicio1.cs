using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

    /*
     Exercício 1 – Pontos de Experiência do Personagem
Um personagem derrotou 3 inimigos pequenos, 2 inimigos médios e 1 inimigo chefe.
• Cada inimigo pequeno concede 10 XP.
• Cada inimigo médio concede 25 XP.
• O chefe concede 100 XP.
Problema:
Crie variáveis para armazenar a quantidade de inimigos derrotados e o XP de cada tipo.
Calcule o XP total ganho pelo personagem e mostre o resultado no console usando print().

*/
    [SerializeField] private int inimigoP = 10;
    [SerializeField] private int inimigoM = 25;
    [SerializeField] private int inimigoChefe = 100;
    [SerializeField] private int inimigosMortosP = 3;
    [SerializeField] private int inimigosMortosM = 2 ;
    [SerializeField] private int inimigosMortosChefe = 1;

    void Start()
    {
        int PontuaçãoFinal = (inimigoP + inimigoM + inimigoChefe);
        print("Você matou  " + (inimigosMortosP) + " inimigos pequenos,  " + (inimigosMortosM) + " inimigos médios e você derrotou " + (inimigosMortosChefe) +  " chefe!" );
        print("Você ganhou no total " + (PontuaçãoFinal) + " De XP!");





    }

    
    void Update()
    {
        
    }
}
