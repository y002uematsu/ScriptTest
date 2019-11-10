using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
	private int hp=100;
	private int power=25;
	private int mp=53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Difence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic(int c){
		if (mp >= c) {
			this.mp -= c;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}  else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}


public class Test : MonoBehaviour{

	// Use this for initialization
	void Start () {
		int[] array = { 0, 1, 2, 3, 4 };
		for (int i = 0; i <array.Length; i ++) {
			Debug.Log (array[i]);
		}
		for (int i=5-1;i>=0;i--){
			Debug.Log (array [i]);
		}


		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Difence (3);
		for (int i = 0; i < 11; i++) {
			lastboss.Magic (5);
		}
	}
}