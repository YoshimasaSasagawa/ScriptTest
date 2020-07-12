using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力

//課題
	int mp = 53; //魔力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

//課題
	public void Magic(int consumption){
		if (mp - consumption >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + (this.mp - consumption) + "。");
			this.mp -= consumption;
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}	
	}
}


public class Test : MonoBehaviour {

	void Hello(string name){
		Debug.Log ("Hello, "+ name);
	}

	int Add(int a, int b){
		int c = a + b;
		return c;
	}

	// Use this for initialization
	void Start () {
		//コンソールにHello, Worldと表示
		Debug.Log ("Hello, World");

		//変数の宣言
		int score;
		//変数の代入
		score = 150;
		//コンソールに変数の中身を表示
		Debug.Log (score);

		//変数同士の計算
		int a = 3;
		int b =	4;
		int c = a + b;
		Debug.Log (c);

		// 要素数5の配列を初期化する
		string[] points = new string[5];

		// 配列の各要素に値を代入する
		points [0] = "30";
		//points [1] = "20";
		points [2] = "50";
		points [3] = "10";
		points [4] = "80";

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

//課題
		int[] array = {1, 10, 100, 22, 33};
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
		}
			
		Hello ("UnityChan");

		int num = Add (10, 3);
		Debug.Log (num);


		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);

//課題	
			for(int i = 0; i < 11; i++){
				lastboss.Magic(5);
			}
	}

	// Update is called once per frame
	void Update () {

	}
}