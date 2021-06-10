using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public bool jogador1PainelResolved = false;

    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    public static bool vezdoJogador1;

    public static bool jogador1Respondeuaquest;

    public static int diceSideThrown = 0;

    public GameObject painelEvento;

    public GameObject painelEvento2;

    public GameObject painelEvento3;

    public GameObject painelEvento4;

    public GameObject limiteCartao;

    public float dinheiroJogador1;

    public TextMeshProUGUI dinheiroTxtJogador1;

    public float limitecartaoJogador1;

    public TextMeshProUGUI limitecartaoTxtJogador1;

    public float medalhasJogador1;

    public TextMeshProUGUI medalhasTxtJogador1;

    // Use this for initialization
    void Start () 
    {
        whoWinsTextShadow = GameObject.Find("QuemVenceu");
        player1MoveText = GameObject.Find("VezJogador1");
        player2MoveText = GameObject.Find("VezJogador2");

        player1 = GameObject.Find("Ana Maria");
        player2 = GameObject.Find("Jogador2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        //whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        limitecartaoTxtJogador1.text = limitecartaoJogador1.ToString("N"); //Cod pra transformar o limite do cartao em TXT no HUD

        dinheiroTxtJogador1.text = dinheiroJogador1.ToString("N"); //Cod pra transformar o dinheiro em TXT no HUD

        medalhasTxtJogador1.text = medalhasJogador1.ToString(); 

        print(player1.GetComponent<FollowThePath>().waypointIndex);

        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            //whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Venceu";
            //gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            //whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Venceu";
            //gameOver = true;
        }

        // 02.06.2021
        
        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 2
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
                painelEvento.SetActive(true);
                print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 3
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 4
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");

        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 5
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }


        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 6
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 7
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 8
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 9
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 10
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 11
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 12
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 13
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 14
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 15
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 16
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 17
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 18
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 19
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 20
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 21
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 22
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 23
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 24
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) 
        { 
            case 1:
                jogador1Respondeuaquest = false;
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                vezdoJogador1 = true;
                print("Vez do Jogador 1");
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

    public void Evento1BtnSim()
    { 
        dinheiroJogador1 = dinheiroJogador1 + 700;
        jogador1PainelResolved = true;
        painelEvento.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

    public void Evento1BtnNao()
    {
        jogador1PainelResolved = true;
        painelEvento.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

    public void Evento2BtnSim()
    {
        limiteCartao.gameObject.SetActive(true);
        limitecartaoTxtJogador1.gameObject.SetActive(true);
        limitecartaoJogador1 = limitecartaoJogador1 + 200;
        jogador1PainelResolved = true;
        painelEvento2.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

    public void Evento2BtnNao()
    {
        jogador1PainelResolved = true;
        painelEvento2.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

    public void Evento3Oba()
    {
        medalhasJogador1 = medalhasJogador1 + 1;
        jogador1PainelResolved = true;
        painelEvento3.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

    public void Evento4Prejuizo()
    {
        dinheiroJogador1 = dinheiroJogador1 - 50;
        jogador1PainelResolved = true;
        painelEvento4.SetActive(false);
        jogador1Respondeuaquest = true;
        print("Painel fechado");
    }

}
