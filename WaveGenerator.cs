using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveGenerator : MonoBehaviour {
	public static WaveGenerator instance;
	public List<Transform> particles = new List<Transform>();
	public float T1, A1, lambda1, T2, A2, lambda2, speed;
	private float t0;
	private bool simulationRunning=false;
	public GameObject cube;
	public GameObject firstSource, secondSource, mainUI, inputFieldParent;
	public Slider lambda1ui, lambda2ui, t1ui, t2ui, a1ui, a2ui;
	public Text t1text, t2text, a1text, a2text, lambda1text, lambda2text;
	public InputField numberOfCubes;
	public int size;
	void Awake() {
		if(instance==null) {
			instance = this;
			t0 = Time.time;
		}
	}
	void Update() {
		if(simulationRunning) {
		foreach(Transform particle in particles) {
		float sourceOneDisplacement = A1*Mathf.Sin(2*Mathf.PI*((Time.time-t0)/T1-Mathf.Sqrt(Mathf.Pow((firstSource.transform.position.x-particle.position.x),2)+Mathf.Pow(firstSource.transform.position.z-particle.position.z,2))/lambda1));
		float sourceTwoDisplacement = A2*Mathf.Sin(2*Mathf.PI*((Time.time-t0)/T2-Mathf.Sqrt(Mathf.Pow((secondSource.transform.position.x-particle.position.x),2)+Mathf.Pow(secondSource.transform.position.z-particle.position.z,2))/lambda2));		
		particle.position = new Vector3(particle.position.x, sourceOneDisplacement+sourceTwoDisplacement, particle.position.z);
		}
		}
	}
	public void StartSimulation () {
		int.TryParse(numberOfCubes.text, out size); //Why is this necessary?
		for(int i=0; i<size; i++) {
			for(int j=0; j<size; j++) {
			GameObject clone = Instantiate(cube, new Vector3(j*0.1f, 0f, i*0.1f), Quaternion.identity);
			particles.Add(clone.transform);
			}
		}
		Destroy(inputFieldParent);
		simulationRunning = true;
	}
	public void ChangeSomething(string whatToChange) {
		switch (whatToChange) {
			case "L1":
			lambda1 = lambda1ui.value;
			lambda1text.text = lambda1ui.value.ToString("0.0") + " m";
			break;
			case "L2":
			lambda2 = lambda2ui.value;
			lambda2text.text = lambda2ui.value.ToString("0.0") + " m";
			break;
			case "T1":
			T1 = t1ui.value;
			t1text.text = t1ui.value.ToString("0.0") + " s";
			break;
			case "T2":
			T2 = t2ui.value;
			t2text.text = t2ui.value.ToString("0.0") + " s";
			break;
			case "A1":
			A1 = a1ui.value;
			a1text.text = a1ui.value.ToString("0.0") + " m";
			break;
			case "A2":
			A2 = a2ui.value;
			a2text.text = a2ui.value.ToString("0.0") + " m";
			break;
		}
	}
	public void ShowHideUI() {
		mainUI.SetActive(!mainUI.activeSelf);
	}
}