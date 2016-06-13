using UnityEngine;
using System.Collections;

public class pathscript : MonoBehaviour {
	public int level = 1;
	public bool ready = false;
	public GameObject aguaVasilha;
	public GameObject aguaPiscina;
	public GameObject aguaPneu;
	// Use this for initialization
	void Start () {
		aguaVasilha = GameObject.FindGameObjectWithTag ("aguaVasilha");
		aguaPiscina = GameObject.FindGameObjectWithTag ("aguaPiscina");
		aguaPneu = GameObject.FindGameObjectWithTag ("aguaPneu");
		aguaPneu.SetActive (false);
		aguaVasilha.SetActive (false);
		aguaPiscina.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (level == 1) {
			level1 ();
		} else {
			if (level == 2 && ready) {
				level2 ();
			} else {
				if (level == 3 && ready) {
					level4 ();
				}
			}
		}
			
	}

	void level1(){
		level = 2;
		aguaVasilha.SetActive (true);
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("PathTest"), "time", 20));
	}
	void level2(){
		level = 3;
		ready = false;
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("PathTest2"), "time", 20));
		aguaVasilha.SetActive (false);
		aguaPneu.SetActive (true);
	}

	void level4(){
		
		level = 5;
		ready = false;
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("PathTest3"), "time", 20));
		aguaPneu.SetActive (false);
		aguaPiscina.SetActive (true);
	}

}

