using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameScript : MonoBehaviour
{
    public Text text1;
    public Text text2;

    public GameObject checkbox1;
    public GameObject checkbox2;
    public GameObject f1;
    public GameObject s1;
    public GameObject f2;
    public GameObject s2;

    public GameObject motion1;
    public GameObject motion2;

    public GameObject player1;
    public GameObject player2;
    public GameObject winner;

    int value1, value2;
    int v_ch1, v_ch2;

    bool check_first = true;
    bool check_second = true;
    bool startgame = false;
    bool who = true;

    private void Start()
    {
        s1.gameObject.SetActive(false);
        s2.gameObject.SetActive(false);
        motion2.gameObject.SetActive(false);
        
        winner.gameObject.SetActive(false);
        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (startgame == false)
        {
            v_ch1 = Convert.ToInt32(text1.text);
            value1 = Convert.ToInt32(text1.text);

            v_ch2 = Convert.ToInt32(text2.text);
            value2 = Convert.ToInt32(text2.text);
        }
    }

    public void ClickPlus()
    {
        if (startgame == false)
            startgame = true;

        if ((check_first == true) && (check_second == true))
        {
            if ((v_ch1 < value1) && (v_ch2 < value2))
            {
                v_ch1++;
                v_ch2++;
                text1.text = v_ch1.ToString();
                text2.text = v_ch2.ToString();
            }
        }
        else
            if (check_first == true)
        {
            if (v_ch1 < value1)
            {
                v_ch1++;
                text1.text = v_ch1.ToString();
            }
        }
        else
            if (check_second == true)
        {
            if (v_ch2 < value2)
            {
                v_ch2++;
                text2.text = v_ch2.ToString();
            }
        }
    }

    public void ClickMinus()
    {
        if (startgame == false)
            startgame = true;

        if ((check_first == true) && (check_second == true))
        {
            if ((v_ch1 > 0) && (v_ch2 > 0))
            {
                v_ch1--;
                v_ch2--;
                text1.text = v_ch1.ToString();
                text2.text = v_ch2.ToString();
            }
        }
        else
            if (check_first == true)
        {
            if (v_ch1 > 0)
            {
                v_ch1--;
                text1.text = v_ch1.ToString();
            }
        }
        else
            if (check_second == true)
        {
            if (v_ch2 > 0)
            {
                v_ch2--;
                text2.text = v_ch2.ToString();
            }
        }
    }

    public void Changed_Color1()
    {
        if ((v_ch1 == value1)&& (v_ch2 == value2))
        {
            if (check_first == true)
            {
                f1.gameObject.SetActive(false);
                s1.gameObject.SetActive(true);
                check_first = false;

            }
            else
            {
                f1.gameObject.SetActive(true);
                s1.gameObject.SetActive(false);
                check_first = true;
            }
        }
    }

    public void Changed_Color2()
    {
        if ((v_ch2 == value2)&&(v_ch1 == value1))
        {
            if (check_second == true)
            {
                f2.gameObject.SetActive(false);
                s2.gameObject.SetActive(true);
                check_second = false;
            }
            else
            {
                f2.gameObject.SetActive(true);
                s2.gameObject.SetActive(false);
                check_second = true;
            }
        }
    }

    public void Done()
    {
        if ((v_ch1 != value1) || (v_ch2 != value2))
        {
            if ((v_ch1 != 0) || (v_ch2 != 0))
            {
                value1 = v_ch1;
                value2 = v_ch2;

                if (who == true)
                {
                    motion1.gameObject.SetActive(false);
                    motion2.gameObject.SetActive(true);
                    who = false;
                }
                else
                {
                    motion1.gameObject.SetActive(true);
                    motion2.gameObject.SetActive(false);
                    who = true;
                }
            }
            else
            {
                value1 = value2 = 0;
                winner.gameObject.SetActive(true);
                if (who == true)
                {
                    player1.gameObject.SetActive(true);
                }
                else
                {
                    player2.gameObject.SetActive(true);
                }
            }
        }
    }

}

