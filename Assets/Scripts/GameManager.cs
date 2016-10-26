using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	private int horizontal=10;// Количество блоков по горизонтали
	private int vertical=2;// Количество блоков по вертикали
	private GameObject[,] block;
	public GameObject [] _listOfblocks;
	private GameObject temp;
	public GameObject bonus_1; 
	public GameObject bonus_2;
	public GameObject bonus_3;
	private int bonus_number;
	public static Vector3 Position_for_bonus;
	public static float timer; //Таймер для Бонусов
	public static int col_ball;// количесвто шаров на поле
	public static int blocks_destroed; //подсчёт уничтоженных блоков
	public Text Lose_win; //Текст В случае пройгрыша или поражения
	public static bool Pause_; //Пауза
	private int Pause_c;
	public static float Total;
	public Text Total_;
	// Use this for initialization
	void Start () {
		col_ball = 1;
		block = new GameObject[horizontal, vertical];

		for ( int i = 0; i <= horizontal-1; i++){ // создание массива блоков 
			for ( int j = 0; j <= vertical-1; j++){
				var gameObject = GameObject.Instantiate(_listOfblocks[Random.Range(0, _listOfblocks.Length)] as GameObject, new Vector3(i-5, j+2, 0), transform.rotation) as GameObject;
				block[i,j]= gameObject;
				blocks_destroed=horizontal*vertical;
			}
		}
	 }
	void Update () {
		Total_ .text= "Total: "+Total.ToString();
		timer += Time.deltaTime; //таймер
		if (Blocks_red.Destroy_red == true) { // если Блок уничтожен то выпадает если повезёт, то выпадет один из трёх возможных бонуосв
			Position_for_bonus=Blocks_red.vector_red;
			bonus_number=Random.Range(0,5);
			Debug.Log("Номер бонуса"+bonus_number);
			if(bonus_number==1)
				Instantiate(bonus_1, Position_for_bonus, Quaternion.identity);
			if(bonus_number==2)
				Instantiate(bonus_2, Position_for_bonus, Quaternion.identity);
			if(bonus_number==3)
				Instantiate(bonus_3, Position_for_bonus, Quaternion.identity);
			Blocks_red.Destroy_red=false;
		}
		if (Blocks_green.Destroy_green == true) {// если Блок уничтожен то выпадает если повезёт, то выпадет один из трёх возможных бонуосв
			Position_for_bonus=Blocks_green.vector_green;
			bonus_number=Random.Range(0,5);
			Debug.Log("Номер бонуса"+bonus_number);
			if(bonus_number==1)
				Instantiate(bonus_1, Position_for_bonus, Quaternion.identity);
			if(bonus_number==2)
				Instantiate(bonus_2, Position_for_bonus, Quaternion.identity);
			if(bonus_number==3)
				Instantiate(bonus_3, Position_for_bonus, Quaternion.identity);
			Blocks_green.Destroy_green=false;
		}
		if (Blocks_pink.Destroy_pink == true) {// если Блок уничтожен то выпадает если повезёт, то выпадет один из трёх возможных бонуосв
			Position_for_bonus=Blocks_pink.vector_pink;
			bonus_number=Random.Range(0,5);
			Debug.Log("Номер бонуса"+bonus_number);
			if(bonus_number==1)
				Instantiate(bonus_1, Position_for_bonus, Quaternion.identity);
			if(bonus_number==2)
				Instantiate(bonus_2, Position_for_bonus, Quaternion.identity);
			if(bonus_number==3)
				Instantiate(bonus_3, Position_for_bonus, Quaternion.identity);
			Blocks_pink.Destroy_pink=false;
		}
		 
		if (col_ball == 0) //если количесвто шаров на поле которые не коснулись огня =0 то вы проиграли
		{
			Lose_win.text="YOU LOSE NOOB";

		}
		if (blocks_destroed == 0) { //если все локи уничтожены

			Lose_win.text="YOU WIN NOOB";
		}
}

	public void Pause_button() //функция для кнопки паузы
	{   
		Pause_ = true;
		Pause_c++;
		if (Pause_c == 2) {
			Pause_ = false;
			Pause_c=0;
		}

	}
	public void Exite()// выход из игры
	{
		Application.Quit ();
		
	}
}
