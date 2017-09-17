﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SensorAbstract : MonoBehaviour {


	public List<float> inputData;
	public List<float> averages;
	public int register;

	//metoda dodająca daną do tablicy
	public abstract void addInput(float data);

	//metoda licząca średnią
	public abstract void calculateAverage();

	//metoda porównująca średnie
	public abstract bool compareAverage();

}