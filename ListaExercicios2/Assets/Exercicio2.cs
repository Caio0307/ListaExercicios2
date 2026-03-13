using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    /*
    Exercício 2 – Dano Total do Ataque
Um personagem possui um ataque que causa 15 de dano base.
Durante o combate aconteceram os seguintes bônus:
• Um bônus de arma que adiciona 5 de dano
• Um bônus temporário que multiplica o dano por 2
Problema:
Crie variáveis para os valores do dano base e dos bônus.
Calcule o dano final do ataque e imprima o resultado no console usando print().
    */

    int danoBase = 15;
    int BonusArma = 5;
    int BonusTemp = 2;




    void Start()
    {
        int DanoFinal = (danoBase + BonusArma) * BonusTemp;
        print("Seu Dano Base é " + (danoBase));
        print("Porém você recebeu um bônus em sua arma de " + (BonusArma) + " de Dano, e junto um bônus temporário que irá multiplicar seu dano em " + (BonusTemp));
        print("Seu dano final é de " + (DanoFinal));


    }

    
    void Update()
    {
        
    }
}
