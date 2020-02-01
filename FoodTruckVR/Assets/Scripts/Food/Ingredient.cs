﻿using UnityEngine;

/** All the different types of ingredients that can appear in the game */
public enum IngredientType
{
	Beef,
	Cheese,
	Lettuce,
	Tomato,
	Bean,
}

/** Attached to in-game objects to identify what ingredient they are */
public class Ingredient : MonoBehaviour
{
	/** This ingredient's type */
	public IngredientType IngredientType;
}

